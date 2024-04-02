using Application.Example;
using MelbergFramework.Core.ComponentTesting;
using MelbergFramework.Core.DependencyInjection;
using MelbergFramework.Core.HealthCheck;
using MelbergFramework.Core.Time;
using MelbergFramework.Application;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var app = MelbergHost
            .CreateHost<DemoRegistrator>()
            .AddControllers()
            .Build();

        var isGood = await app
            .Services.GetRequiredService<IHealthCheckChecker>().IsOk();


        await app.RunAsync();
    }

}
