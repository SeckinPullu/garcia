﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Garcia.Domain.MongoDb;
using Garcia.Application.MongoDb.Contracts.Persistence;
using Garcia.Infrastructure.MongoDb;

namespace Garcia.Persistence.MongoDb
{
    public class MongoDbRepository<T> : IAsyncMongoDbRepository<T> where T : MongoDbEntity
    {
        protected readonly IMongoCollection<T> Collection;

        public MongoDbRepository(IOptions<MongoDbSettings> options)
        {
            var settings = options.Value;
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Collection = database.GetCollection<T>(typeof(T).Name);
        }

        public MongoDbRepository(MongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Collection = database.GetCollection<T>(typeof(T).Name);
        }

        public async Task<long> AddAsync(T entity)
        {
            await Collection.InsertOneAsync(entity);
            return entity == null ? 0 : 1;
        }

        public async Task<long> AddRangeAsync(IEnumerable<T> entities)
        {
            var options = new BulkWriteOptions
            {
                IsOrdered = false,
                BypassDocumentValidation = false
            };

            return (await Collection.BulkWriteAsync(entities.Select(x => new InsertOneModel<T>(x)), options)).InsertedCount;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            var count = await Collection.CountDocumentsAsync(filter);
            return count > 0;
        }

        public async Task<long> DeleteAsync(T entity, bool hardDelete = false)
        {
            if(!hardDelete)
            {
                entity.Deleted = true;
                await Collection.FindOneAndReplaceAsync(x => x.Id == entity.Id, entity);
                return entity == null ? 0 : 1;
            }

            return (await Collection.DeleteOneAsync(x => x.Id == entity.Id)).DeletedCount;
        }

        public async Task<long> DeleteManyAsync(Expression<Func<T, bool>> filter, bool hardDelete = false)
        {
            if(!hardDelete)
            {
                var definition = Builders<T>.Update.Set(x => x.Deleted, true);
                return (await Collection.UpdateManyAsync(filter, definition)).ModifiedCount;
            }

            return (await Collection.DeleteManyAsync(filter)).DeletedCount;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await (await Collection
                .FindAsync(x => !x.Deleted))
                .ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(int page, int size)
        {
            return await Collection
                .Aggregate()
                .Match(x => !x.Deleted)
                .Skip((page - 1) * size)
                .Limit(size)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await (await Collection
                .FindAsync(filter))
                .ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await (await Collection
                .FindAsync(x => !x.Deleted && x.Id == id))
                .FirstOrDefaultAsync();
        }

        public async Task<long> UpdateAsync(T entity)
        {
            await Collection.FindOneAndReplaceAsync(x => x.Id == entity.Id, entity);
            return entity == null ? 0 : 1;
        }

        public async Task<long> UpdateManyAsync(Expression<Func<T, bool>> filter, UpdateDefinition<T> definition)
        {
            return (await Collection.UpdateManyAsync(filter, definition)).ModifiedCount;
        }
    }
}