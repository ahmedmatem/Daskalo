using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using Azure;
using Daskalo.Core.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Daskalo.Core.Services
{
    public class AzureStorageService : IAzureStorageService
    {
        private readonly BlobServiceClient blobServiceClient;
        private readonly BlobContainerClient blobContainerClient;

        public string BlobContainerURL { get; init; }

        public AzureStorageService(BlobServiceClient client, IConfiguration configuration)
        {
            BlobContainerURL = configuration.GetValue<string>("AzureStorage:Containers:TopicResources:URL")
                ?? string.Empty;
            blobServiceClient = client;
            string containerName = configuration.GetValue<string>("AzureStorage:Containers:TopicResources:Name")
                ?? string.Empty;
            blobContainerClient = client.GetBlobContainerClient(containerName);
        }

        public async Task<Response<BlobContentInfo>> UploadFileAsync(IFormFile file, string blobName)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                memoryStream.Position = 0;
                return await blobContainerClient.UploadBlobAsync(blobName, memoryStream, default);
            }
        }

        public async Task<List<BlobItem>> GetUploadedBlobsAsync()
        {
            var items = new List<BlobItem>();
            var uploadedFiles = blobContainerClient.GetBlobsAsync();
            await foreach (BlobItem file in uploadedFiles)
            {
                items.Add(file);
            }

            return items;
        }

        public async Task<Azure.Response<bool>> DeleteAsync(string blobName)
        {
            return await blobContainerClient
                .DeleteBlobIfExistsAsync(blobName, DeleteSnapshotsOption.IncludeSnapshots);
        }
    }
}
