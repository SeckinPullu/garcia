﻿using GarciaCore.Application.Contracts.FileUpload;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaCore.Application.Services
{
    public partial class LocalFileUploadService : IFileUploadService
    {
        private FileUploadSettings _settings;

        public LocalFileUploadService(IOptions<FileUploadSettings> settings)
        {
            _settings = settings.Value;
        }

        protected FileWrapper GetDetails(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return new FileWrapper();
            }

            return new FileWrapper(fileName, _settings.BaseUrl, $"{_settings.FileUploadPath}/{fileName}", $"{_settings.BaseUrl}/{_settings.FileUploadPath}/{fileName}", fileName.Split('.').Last());
        }

        public string GetFileName(string url)
        {
            return url.Replace($"{_settings.BaseUrl}/{_settings.FileUploadPath}/", "");
        }

        public string GetUrl(string fileName)
        {
            return GetDetails(fileName).Url;
        }

        public async Task<string> UploadAsync(IFormFile file)
        {
            var targetDirectory = _settings.FileUploadPath;
            var fileName = $"{file.FileName}";
            var savePath = Path.Combine(targetDirectory, fileName).Replace("/", "\\");

            using (var fileStream = new FileStream(savePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return fileName;
        }
    }
}