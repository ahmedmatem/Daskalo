
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using Azure;
using Daskalo.Core.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Daskalo.Core.Services
{
    public class TopicResourceStorageService : ITopicResourceStorageService
    {
        public string ContainerUrl { get; init; }

        private readonly BlobContainerClient blobContainerClient;

        public TopicResourceStorageService(
            BlobServiceClient client,
            IConfiguration configuration)
        {
            ContainerUrl = configuration
                .GetValue<string>("AzureStorage:Containers:TopicResources:URL");
            string containerName = configuration
                .GetValue<string>("AzureStorage:Containers:TopicResources:Name");
            blobContainerClient = client.GetBlobContainerClient(containerName);
        }

        public async Task<Response<BlobContentInfo>> UploadFileAsync(IFormFile file, string blobName)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                memoryStream.Position = 0;
                return await blobContainerClient
                    .UploadBlobAsync(blobName, memoryStream, default);
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

        public async Task<Response<bool>> DeleteAsync(string blobName)
        {
            return await blobContainerClient.DeleteBlobIfExistsAsync(
                blobName, DeleteSnapshotsOption.IncludeSnapshots);
        }
    }
}
