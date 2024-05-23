using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace Daskalo.Core.Contracts
{
    public interface IAzureStorageService
    {
        public string BlobContainerURL { get; }

        Task<Azure.Response<BlobContentInfo>> UploadFileAsync(IFormFile file, string blobName);

        Task<Azure.Response<bool>> DeleteAsync(string blobName);
    }
}
