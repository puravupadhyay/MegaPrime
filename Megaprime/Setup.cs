using Megaprime.Services;
using Megaprime.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Megaprime
{
    /// <summary>
    /// Class for configuring dependency injection
    /// </summary>
    /// <returns></returns>
    public static class Setup
    {
        public static ServiceProvider SetupDependencyInjection()
        {
            return new ServiceCollection()
                .AddSingleton<INumberService, NumberService>()
                .AddSingleton<IMegaPrimeService, MegaPrimeService>()
                .AddSingleton<IPrintService, PrintService>()
                .BuildServiceProvider();
        }
    }
}
