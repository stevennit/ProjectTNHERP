﻿using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Common
{
    public class FileStorageService : IStorageService
    {
        private static string USER_CONTENT_FOLDER_NAME = "user-content";
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileStorageService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string GetFileUrl(string fileName)
        {
            return $"/{USER_CONTENT_FOLDER_NAME}/{fileName}";
        }

        public async Task SaveFileAsync(Stream mediaBinaryStream, string folderName, string fileName)
        {

            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, folderName, fileName);
            var dirPath = Path.Combine(_webHostEnvironment.WebRootPath, folderName);

            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            using var output = new FileStream(filePath, FileMode.Create);
            await mediaBinaryStream.CopyToAsync(output);
        }

        public async Task DeleteFileAsync(string folderName, string fileName)
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, folderName, fileName);

            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }
    }
}