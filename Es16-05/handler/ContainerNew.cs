using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es16_05.handler
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public static class ContainerNEW
    {
        public static IHost CreateHostBuilder()
        {
            return Host
                .CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                {
                    services.AddSingleton<NullHandler>();
                    services.AddSingleton<MultiNameHandler>();
                    services.AddSingleton<ShoutHandler>();
                    services.AddSingleton<TwoNamesHandler>();
                    services.AddSingleton<BaseGreetHandler>();
                    services.AddSingleton<IGreet>((serviceProvider) =>
                    {
                        var nullHandler = serviceProvider.GetService<NullHandler>();
                        var multiNameHandler = serviceProvider.GetService<MultiNameHandler>();
                        var shoutHandler = serviceProvider.GetService<ShoutHandler>();
                        var twoNamesHandler = serviceProvider.GetService<TwoNamesHandler>();
                        var baseGreetHandler = serviceProvider.GetService<BaseGreetHandler>();

                        nullHandler.SetSuccessor(multiNameHandler)
                                   .SetSuccessor(shoutHandler)
                                   .SetSuccessor(twoNamesHandler)
                                   .SetSuccessor(baseGreetHandler);

                        return nullHandler;
                    });
                }).Build();
        }
    }

}