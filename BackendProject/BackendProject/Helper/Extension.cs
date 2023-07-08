using Microsoft.AspNetCore.Hosting;
namespace BackendProject.Helper
{
    public static class Extension
    {
        public static bool CheckFileType(this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }
        public static bool ChechkFileSize(this IFormFile file, int size)
        {
            return file.Length < size;
        }
        public static string SaveImage(this IFormFile file, IWebHostEnvironment webHostEnvironment, string mainfolder,string folder)
        {
            string fileName = Guid.NewGuid() + file.FileName;
            string path = Path.Combine(webHostEnvironment.WebRootPath, mainfolder, folder, fileName);
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            return fileName;

        }
    }
}
