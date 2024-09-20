
namespace HelloWorldApi.Model
{
    using HelloWorldApi.Applibs;

    public class ConfigService : IConfigService
    {
        public string Evn 
            => ConfigHelper.Env;
    }
}
