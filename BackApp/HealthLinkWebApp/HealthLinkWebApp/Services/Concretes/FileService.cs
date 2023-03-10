using HealthLinkWebApp.Contracts.File;
using HealthLinkWebApp.Services.Abstracts;

namespace HealthLinkWebApp.Services.Concretes
{
    public class FileService : IFileService
    {
        private readonly ILogger<FileService>? _logger;

        public FileService(ILogger<FileService>? logger)
        {
            _logger = logger;
        }
        public async Task<string> UploadAsync(IFormFile formFile, UploadDirectory uploadDirectory)
        {
            //connection ucun lazim olan path yeni data harda saxlanilacaq
            string directoryPath = GetUploadDirectory(uploadDirectory);

            //patha gore muvafiq faylin olub olmamasini yoxlamaq yoxdursa yaratmaq
            CheckPathExists(directoryPath);

            //sistem daxilinde qarmasiqliq olmasin deye daxil olan file-in adini uniqe sekilde saxlamaq
            var imageNameInSystem = CreateUniqueFileName(formFile.FileName);

            //stream ucun lazim olan upload pathini yaratmaq mes wwwroot/client/file/books/8as8a8sas.jpg
            var uploadPath = Path.Combine(directoryPath, imageNameInSystem);

            try //stream problemlere yol aca biler buna gorede 
            {
                //stream configiguration
                using FileStream fileStream = new FileStream(uploadPath, FileMode.Create);

                //emeliyyat sistemine stream uzerinden fayli yazmaq
                await formFile.CopyToAsync(fileStream);
            }
            catch (Exception e)
            {

                _logger!.LogError(e, "Error occured in file service");

                throw;
            }


            return imageNameInSystem;
        }

        //connection ucun lazim olan path yeni data harda saxlanilacaq
        private string GetUploadDirectory(UploadDirectory uploadDirectory)
        {
            var initialPath = Path.Combine("wwwroot", "client", "custom-files");
            switch (uploadDirectory)
            {
                case UploadDirectory.Proudct:
                    return Path.Combine(initialPath, "products");
                case UploadDirectory.Slider:
                    return Path.Combine(initialPath, "sliders");
                case UploadDirectory.PaymentBenefits:
                    return Path.Combine(initialPath, "paymentBenefits");
                case UploadDirectory.Reward:
                    return Path.Combine(initialPath, "rewards");
                case UploadDirectory.FeedBack:
                    return Path.Combine(initialPath, "feedBacks");
                case UploadDirectory.Blog:
                    return Path.Combine(initialPath, "blogs");

                default:
                    throw new Exception("Something went wrong");
            }
        }

        //patha gore muvafiq faylin olub olmamasini yoxlamaq yoxdursa yaratmaq
        private void CheckPathExists(string directoryPath)
        {
            if (!Directory.Exists(directoryPath)) // pathin yoxlanilmasi bu patha uygun folder yoxdursa yaradilmasi process
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
        //sistem daxilinde qarmasiqliq olmasin deye daxil olan file-in adini uniqe sekilde saxlamaq
        private string CreateUniqueFileName(string formFile)
        {
            return $"{Guid.NewGuid()}{Path.GetExtension(formFile)}";
        }

        public async Task DeleteAsync(string? fileName, UploadDirectory uploadDirectory)
        {
            var deletePath = Path.Combine(GetUploadDirectory(uploadDirectory), fileName);

            await Task.Run(() => File.Delete(deletePath));
        }
        public string GetFileUrl(string? fileName, UploadDirectory uploadDirectory)
        {
            string initialSegment = "client/custom-files/";

            switch (uploadDirectory)
            {
                case UploadDirectory.Proudct:
                    return $"{initialSegment}/products/{fileName}";
                case UploadDirectory.Slider:
                    return $"{initialSegment}/sliders/{fileName}";
                case UploadDirectory.PaymentBenefits:
                    return $"{initialSegment}/paymentBenefits/{fileName}";
                case UploadDirectory.Reward:
                    return $"{initialSegment}/rewards/{fileName}";
                case UploadDirectory.FeedBack:
                    return $"{initialSegment}/feedBacks/{fileName}";
                case UploadDirectory.Blog:
                    return $"{initialSegment}/blogs/{fileName}";
                default:
                    throw new Exception("Something went wrong");
            }
        }



    }
}
