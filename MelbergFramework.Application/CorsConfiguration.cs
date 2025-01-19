namespace MelbergFramework.Application;
public class CorsConfiguration
{
    public static string Section => "Cors";

    public string[] AllowedHosts {get; set;} = [];
}
