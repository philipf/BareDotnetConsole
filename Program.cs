using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BareDotnetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging(configure => {
                    configure.ClearProviders();
                    configure.AddConsole();
                    configure.AddFilter(typeof(Program).Namespace, LogLevel.Debug);
                })
                .AddSingleton<IBarService, BarService>()
                .BuildServiceProvider();

            var logger = serviceProvider
                .GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            logger.LogInformation("Starting application");

            var bar = serviceProvider.GetService<IBarService>();
            bar.DoSomeRealWork();

            logger.LogDebug("All done!");
        }
    }
}
