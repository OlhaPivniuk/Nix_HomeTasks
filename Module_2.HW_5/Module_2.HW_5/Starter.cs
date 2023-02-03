using Module_2.HW_5.Providers.Abstractions;
using Module_2.HW_5.Providers;
using Module_2.HW_5.Services.Abstractions;
using Module_2.HW_5.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Module_2.HW_5
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IFileService, FileService>()
                .AddSingleton<IConfigProvider, ConfigProvider>()
                .AddSingleton<ILoggerService, LoggerService>()
                .AddTransient<Actions>()
                .AddTransient<App>()
                .BuildServiceProvider();
            var app = serviceProvider.GetService<App>();

            app?.Run();
        }
    }
}
