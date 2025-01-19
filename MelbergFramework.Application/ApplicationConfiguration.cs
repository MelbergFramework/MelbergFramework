using System.ComponentModel.DataAnnotations;

namespace MelbergFramework.Application;
public class ApplicationConfiguration
{
    public static string Section => "Application";
    [Required]
    [MinLength(1)]
    public string Name {get; set;} = "";
    [Required]
    [MinLength(1)]
    public string Version {get; set;} = "";
}
