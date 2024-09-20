
namespace HelloWorldApi.Applibs
{
    using System.Reflection;
    using Autofac;
    using Autofac.Integration.WebApi;
    using HelloWorldApi.Model;

    internal static class AutofacConfig
    {
        private static IContainer container;

        public static IContainer Container
        {
            get
            {
                if (container == null)
                {
                    Register();
                }

                return container;
            }
        }

        public static void Register()
        {
            var builder = new ContainerBuilder();
            var asm = Assembly.GetExecutingAssembly();
            builder.RegisterApiControllers(asm);

            builder.RegisterType<ConfigService>()
                .As<IConfigService>()
                .SingleInstance();

            container = builder.Build();
        }
    }
}
