﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace StartKitBLL
{
    public class UploadService : IUploadService
    {
        private readonly ILogger _uploadService;
        public UploadService()
        {

        }
        public void DeleteImage(string fileName)
        {
            string sPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Upload"); // Doesn't hit this breakpoint
            try
            {
                SimpleLogger.Log(DateTime.Now+"Deleting file|"+sPath+ "|fileName"+ fileName);
                if (File.Exists(sPath))
                {
                    File.Delete(sPath + @"\" + fileName);
                }

            }
            catch (Exception ex)
            {
                SimpleLogger.Log(DateTime.Now + "Deleting file error|" + sPath + "|fileName" + fileName);
            }
        }

        public int UploadImage(string fileName)
        {
            throw new NotImplementedException();
        }
    }

    public interface IUploadService
    {
        void DeleteImage(string fileName);
        int UploadImage(string fileName);
    }
}
