﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarciaCore.Application.Contracts.Infrastructure;
using GarciaCore.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace GarciaCore.Infrastructure
{
    public static class ServiceBusRegistration
    {
        public static IServiceCollection AddConsumer<TConsumer, TMessage>(this IServiceCollection services)
            where TMessage : IMessage
            where TConsumer : BaseConsumer<TMessage>
        {
            return services.AddHostedService<TConsumer>();
        }

        public static IServiceCollection AddServiceBus<TImplementer>(this IServiceCollection services)
            where TImplementer : class, IServiceBus
        {
            return services.AddSingleton<IServiceBus, TImplementer>();
        }
    }
}
