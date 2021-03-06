using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Utilities.IoC
{
    /// <summary>
    /// Attribute lerde Constructor icerisinde DI yapilamiyor. Bu sorunu cozmek icin metot seviyesinde DI yi otomatik yapan tool.
    /// </summary>
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }

}
