using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Unity;

namespace Prism7_Master.Infrastructure.Bases
{
    public class ViewModelBase : BindableBase
    {
        public ViewModelBase()
        {
        }

        protected IUnityContainer _container;
        protected IRegionManager _regionManager;

        protected void NavigationConfig(string moduleName, string regionName, string viewName)
        {
            IModuleManager moduleManager = _container.Resolve<IModuleManager>();
            moduleManager.LoadModule(moduleName);

            _regionManager.RequestNavigate(regionName, viewName);
        }


        protected void NavigationConfig(string moduleName, string regionName, string viewName, NavigationParameters navigationParameters)
        {
            IModuleManager moduleManager = _container.Resolve<IModuleManager>();
            moduleManager.LoadModule(moduleName);

            _regionManager.RequestNavigate(regionName, viewName, navigationParameters);
        }
    }
}
