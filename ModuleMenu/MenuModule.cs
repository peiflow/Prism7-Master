using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Names = Prism7_Master.Infrastructure.Names;
using Views = ModuleMenu.Views;
namespace ModuleMenu
{
    public class MenuModule : IModule
    {
        #region Properties

        #endregion

        #region Module
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(Names.RegionNames.TOOLBAR_REGION, typeof(Views.Menu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Views.Menu>();
        }
        #endregion
    }
}
