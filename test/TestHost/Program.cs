using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Hosting;
using Orleans.TelemetryConsumers.ElasticSearch;
using System;
using System.Threading.Tasks;

namespace TestHost
{
    class Program
    {
        static Task Main(string[] args)
        {
            Console.Title = nameof(TestHost);


            return new HostBuilder()
                .UseOrleans(builder =>
                {
                    builder
                        .UseLocalhostClustering();
                    //.ConfigureApplicationParts(manager =>
                    //{
                    //    manager.AddApplicationPart(typeof(GameGrain).Assembly).WithReferences();
                    //});


                    builder.AddElasticsearchTelemetryConsumer(new Uri("http://172.28.217.188:9200/"));

                    builder.UseDashboard(options => { });


                })
                .ConfigureLogging(builder =>
                {
                    builder.AddConsole();
                })
                .RunConsoleAsync();
        }
    }
}
