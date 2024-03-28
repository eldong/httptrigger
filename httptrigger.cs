using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

public static class TimerFunction
{
    [FunctionName("TimerFunction")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        string machineName = Environment.MachineName;
        log.LogInformation($"TimerFunction HTTP trigger function processed a request on machine {machineName}.");

        // Start the function run
        log.LogInformation("Function run started.");

        // Simulate some processing time
        await Task.Delay(TimeSpan.FromSeconds(60));

        // End the function run
        log.LogInformation("Function run ended.");

        return new OkResult();
    }
}
