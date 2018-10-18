using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace WindowsServiceHost
{
    public class Service : IHostedService, IDisposable
    {
        private readonly IConfiguration configuration;

        public Service(IConfiguration configuration)
        {
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            // Your service logic starts here

            // Additional info and guidance:
            // https://github.com/Elders/Multithreading.Scheduler
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/hosted-services?view=aspnetcore-2.1
            // https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/multi-container-microservice-net-applications/background-tasks-with-ihostedservice

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            // Make sure that your service stops properly

            return Task.CompletedTask;
        }

        public void Dispose()
        {

        }
    }
}
