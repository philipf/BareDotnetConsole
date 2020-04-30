using System;
using Microsoft.Extensions.Logging;

namespace BareDotnetConsole
{
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
}