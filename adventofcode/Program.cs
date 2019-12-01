using adventofcode.Interfaces;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace adventofcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = ConfigureConfiguration();

            ConfigureContainer(ConfigureServices(configuration))
                .Resolve<IChallangeSelector>()
                .Select()
                .Execute();
        }

        static ServiceCollection ConfigureServices(IConfiguration configuration)
        {
            var services = new ServiceCollection();
            return services;
        }

        static IContainer ConfigureContainer(IServiceCollection services)
        {            
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
            return builder.Build();
        }

        static IConfiguration ConfigureConfiguration()
        {
            var builder = new ConfigurationBuilder()
                 .AddJsonFile($"inputs.2019.json", optional: true, reloadOnChange: false);

            return builder.Build();
        }
    }
}
