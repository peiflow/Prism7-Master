using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Prism7_Master.Views;
using System.Windows;

namespace Prism7_Master
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleMenu.MenuModule>(InitializationMode.WhenAvailable);
            moduleCatalog.AddModule<ModuleContent.ContentModule>(InitializationMode.WhenAvailable);

        }
    }
}
