using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public class ImageFileHelper
    {

        public static string directory = Environment.CurrentDirectory + @"\wwwroot";
        public static string path = @"/images/";
        public static string Add(IFormFile file)
        {

            var sourcepath = Path.GetTempFileName();
            var extension = Path.GetExtension(file.FileName);

            if (file.Length > 0)
            {
                if (extension == ".jpeg" || extension == ".png" || extension == ".jpg" || extension == ".webp" || extension == ".jfif")
                {
                    using (var stream = new FileStream(sourcepath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
            }
            var newFileName = Guid.NewGuid().ToString("N") + extension;
            File.Move(sourcepath, directory + path + newFileName);
            return (path + newFileName).Replace("\\", " / ");
        }
        public static IResult Delete(string oldPath)
        {
            var oldPathRe = (directory + oldPath).Replace("/", "\\");

            try
            {
                File.Delete(oldPathRe);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);
            var newFileName = Guid.NewGuid().ToString("N") + extension;

            if (sourcePath.Length > 0)
            {
                if (extension == ".jpeg" || extension == ".png" || extension == ".jpg")
                {
                    using (var stream = new FileStream(directory + path + newFileName, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
            }
            File.Delete(directory + sourcePath);
            return (path + newFileName).Replace("\\", "/");
        }

    }


}
