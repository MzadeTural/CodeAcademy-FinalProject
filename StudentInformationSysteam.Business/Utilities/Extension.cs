using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Business.Utilities
{
    public static class Extension
    {
     
        public static bool CheckFileSize(this IFormFile file, int kb)
        {
            return file.Length / 1024 <= kb;

        }
        public async static Task<string> SaveFileAysnc(this IFormFile file, string root, string folder)
        {
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string resultPath = Path.Combine(root, folder, fileName);
            using (FileStream stream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;

        }
    }
}
