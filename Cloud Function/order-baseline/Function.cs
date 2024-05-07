using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

namespace order_function;

public class Function : IHttpFunction
{
    /// <summary>
    /// Logic for your function goes here.
    /// </summary>
    /// <param name="context">The HTTP context, containing the request and the response.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task HandleAsync(HttpContext context)
    {
        Console.WriteLine("Order function activated...");
        var body=new StreamReader(context.Request.Body).ReadToEndAsync().Result;
        Console.WriteLine($"Order received: {body}");

        await context.Response.WriteAsync("Order received successfully.");
        Console.WriteLine($"Order function completed");
    }
}
