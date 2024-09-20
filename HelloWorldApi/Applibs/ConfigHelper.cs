
namespace HelloWorldApi.Applibs
{
    using System.Configuration;

    internal static class ConfigHelper
    {
        public static string Env = ConfigurationManager.AppSettings["Env"];
    }
}
