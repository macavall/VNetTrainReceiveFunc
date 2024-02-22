using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace VNetTrainReceiveFunc
{
    public class httpReceiver
    {
        private readonly ILogger<httpReceiver> _logger;

        public httpReceiver(ILogger<httpReceiver> logger)
        {
            _logger = logger;
        }

        [Function("httpReceiver")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Hello httpSender, this is httpReceiver!");
        }
    }
}
