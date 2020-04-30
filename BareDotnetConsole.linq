<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.DependencyInjection</NuGetReference>
  <NuGetReference>Microsoft.Extensions.Logging</NuGetReference>
  <NuGetReference>Microsoft.Extensions.Logging.Console</NuGetReference>
  <Namespace>Microsoft.Extensions.DependencyInjection</Namespace>
  <Namespace>Microsoft.Extensions.Logging</Namespace>
</Query>

void Main()
{
	Startup.Configure();
}

class Startup
{
	public static void Configure()
	{
		var serviceProvider = new ServiceCollection()
		.AddLogging(configure =>
		{
			configure.ClearProviders();
			configure.AddConsole();
			configure.AddFilter(typeof(Startup).Namespace, LogLevel.Debug);
		})
		.AddSingleton<IBarService, BarService>()
		.BuildServiceProvider();

		var logger = serviceProvider
			.GetService<ILoggerFactory>()
			.CreateLogger<Startup>();

		logger.LogInformation("Starting application");

		var bar = serviceProvider.GetService<IBarService>();
		bar.DoSomeRealWork();

		logger.LogDebug("All done!");
	}
}

internal interface IBarService
{
	void DoSomeRealWork();
}

internal class BarService : IBarService
{
	private readonly ILogger<BarService> logger;

	public BarService(ILogger<BarService> logger)
	{
		this.logger = logger;
	}
	public void DoSomeRealWork()
	{
		Console.WriteLine("Real console work!");
		logger.LogDebug("Real console work!");
	}
}