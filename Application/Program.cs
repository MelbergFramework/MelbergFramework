using Application.Example;
using MelbergFramework.Core.HealthCheck;
using MelbergFramework.Application;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var app = MelbergHost
            .CreateHost<DemoRegistrator>()
            .Build();

        var isGood = await app
            .Services.GetRequiredService<IHealthCheckChecker>().IsOk();


        await app.RunAsync();
    }

}
