

using Autofac;
using MyViewModels;

namespace MyWPF
{
    public static class AutofacConfig
    {
        public static IContainer InitContainer()
        {
            var containerVM = MyViewModels.AutofacConfig.InitContainer();

            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().SingleInstance();
            builder.RegisterInstance(containerVM.Resolve<MainWindowVM>()).SingleInstance();

            return builder.Build();
        }
    }
}
