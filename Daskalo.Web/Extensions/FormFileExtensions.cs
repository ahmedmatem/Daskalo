namespace Microsoft.AspNetCore.Http
{
    public static class FormFileExtensions
    {
        /// <summary>
        /// Cheks if file type is an image - default file extensions: jpg, jpeg, png and gif.
        /// </summary>
        /// <param name="file">File checked if it is an image.</param>
        /// <returns>Returns true if actual file extension is an allowed image extension, false otherwise.</returns>
        public static bool IsImage(this IFormFile file)
        {
            string[] allowedFileTypes = new string[] { ".jpg", ".jpeg", ".png", ".gif" };
            var fileExtension = Path.GetExtension(file.FileName).ToLower();
            return allowedFileTypes.Contains(fileExtension);
        }

        /// <summary>
        /// Extension function.
        /// Cheks if file type is an image,
        /// </summary>
        /// <param name="file">File checked if it is an image.</param>
        /// <param name="allowedFileTypes">Nullable collection of allowed file types.</param>
        /// <returns>Returns true if actual file extension is an allowed image extension, false otherwise.</returns>
        public static bool IsImage(this IFormFile file, string[] allowedFileTypes)
        {
            var fileExtension = Path.GetExtension(file.FileName).ToLower();
            return allowedFileTypes.Contains(fileExtension);
        }

        /// <summary>
        /// Extension function.
        /// Checks if file size is less or equals than the given fileSize.
        /// </summary>
        /// <param name="file">File which size is validate.</param>
        /// <param name="fileSize">File maximum size allowed in bytes.</param>
        /// <returns>Returns true if the actual file size is less or equals than the given fileSize 
        /// otherwise returns false.</returns>
        public static bool FileSizeValid(this IFormFile file, long fileSize = 400 * 1024)
        {
            return file.Length <= fileSize;
        }

        /// <summary>
        /// Generate random unique file name.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string RandomName(this IFormFile file)
        {
            var fileExtension = Path.GetExtension(file.FileName);
            return Guid.NewGuid().ToString() + fileExtension;
        }
    }
}
