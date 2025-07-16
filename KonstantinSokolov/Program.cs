using KonstantinSokolov.Models;
using KonstantinSokolov.Services;
using KonstantinSokolov.Services.Printers;

using Microsoft.Extensions.DependencyInjection;

namespace KonstantinSokolov
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IStudentPrinter, StudentConsolePrinter>();
            services.AddSingleton<StudentApp>();

            var provider = services.BuildServiceProvider();

            var app = provider.GetRequiredService<StudentApp>();
            app.Run(useMocks: false);
        }
    }

    

}
