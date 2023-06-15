using Autofac;

namespace MyViewModels
{
    public static class AutofacConfig
    {
        public static IContainer InitContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindowVM>().SingleInstance();

            return builder.Build();
        }
    }
}
