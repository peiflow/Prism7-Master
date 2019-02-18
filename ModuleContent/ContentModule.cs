using ModuleContent.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism7_Master.Infrastructure.Names;

namespace ModuleContent
{
    public class ContentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.CONTENT_REGION, typeof(Content));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Content>();
        }
    }
}
