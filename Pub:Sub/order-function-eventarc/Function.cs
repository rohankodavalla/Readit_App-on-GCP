using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using Google.Cloud.Storage.V1;
using System.Text;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using CloudNative.CloudEvents;
using System.Threading;

namespace order_function;

public class Function : ICloudEventFunction<MessagePublishedData>
{    
    // You Google Storage bucket name
    private const string bucketName = "BUCKET_NAME";

    /// <summary>
    /// Logic for your function goes here.
    /// </summary>
    /// <param name="context">The HTTP context, containing the request and the response.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public Task HandleAsync(CloudEvent cloudEvent, MessagePublishedData data, CancellationToken cancellationToken)
    {
        var storage = StorageClient.Create();

        var objectName = Guid.NewGuid().ToString() + ".json";

        Console.WriteLine("Order function activated...");
        var body = data.Message.TextData;
        Console.WriteLine($"Order received: {body}");

        // Create stream from the string - required by the Cloud Storage API        
        var byteArray = Encoding.UTF8.GetBytes(body);
        var memoryStream = new MemoryStream(byteArray);

        // Upload the order to Cloud Storage
        Console.WriteLine("Start uploading to Cloud Storage...");
        var bucket = storage.UploadObject(bucketName, objectName, null, memoryStream);
        Console.WriteLine("Upload complete successfully.");  

        Console.WriteLine($"Order function completed");
        return Task.CompletedTask;
    }
}
