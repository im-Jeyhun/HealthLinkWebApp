
using HealthLinkWebApp.Contracts.File;

namespace HealthLinkWebApp.Services.Abstracts
{
    public interface IFileService
    {
        Task<string> UploadAsync(IFormFile formFile, UploadDirectory uploadDirectory);
        public Task DeleteAsync(string? fileName, UploadDirectory uploadDirectory);
        public string GetFileUrl(string? fileName, UploadDirectory uploadDirectory);
    }
}
