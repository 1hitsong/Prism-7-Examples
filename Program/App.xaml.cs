using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using Prism.Modularity;
using Program.Views;

namespace Program
{
    internal partial class App : PrismApplication
    {
        protected override Window CreateShell() => Container.Resolve<Shell>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override IModuleCatalog CreateModuleCatalog() => new ConfigurationModuleCatalog();

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ViewLibraryModule>();
        }
    }
}
