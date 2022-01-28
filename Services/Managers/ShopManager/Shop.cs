using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace ShopManager
{
    public class Shop
    {
        private readonly ILogger<Shop> _logger;

        public Shop(ILogger<Shop> log)
        {
            _logger = log;
        }

        [FunctionName("Order")]
        [OpenApiOperation(operationId: "RunOrde", tags: new[] { "Order" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiRequestBody(contentType: "application/json", bodyType: typeof(Order), Description = "User", Required = true)]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.OK, Summary = "The success result", Description = "Operation succeeded")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.BadRequest, Summary = "Invalid Request", Description = "Bad request")]



        public async Task<IActionResult> RunOrder(
                [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, [Queue("accessor", Connection = "StorageConnectionAppSetting")] ICollector<Order> queueCollector)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                var data = JsonConvert.DeserializeObject<Order>(requestBody);



                queueCollector.Add(data);

                return new OkObjectResult("The data was queued");
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Problem: {ex.Message}");
                return new BadRequestObjectResult($"Error: {ex.Message}");
            }
        }


    [FunctionName("Donation")]
    [OpenApiOperation(operationId: "RunDonation", tags: new[] { "Donation" })]
    [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
    [OpenApiRequestBody(contentType: "application/json", bodyType: typeof(Donation), Description = "User", Required = true)]
    [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.OK, Summary = "The success result", Description = "Operation succeeded")]
    [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.BadRequest, Summary = "Invalid Request", Description = "Bad request")]



    public async Task<IActionResult> RunDonation(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, [Queue("accessor", Connection = "StorageConnectionAppSetting")] ICollector<Donation> queueCollector)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        try
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var data = JsonConvert.DeserializeObject<Donation>(requestBody);



            queueCollector.Add(data);

            return new OkObjectResult("The data was queued");
        }
        catch (System.Exception ex)
        {
            _logger.LogError($"Problem: {ex.Message}");
            return new BadRequestObjectResult($"Error: {ex.Message}");
        }
    }



    }




}

