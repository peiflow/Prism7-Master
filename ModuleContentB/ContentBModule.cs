using ModuleContentB.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism7_Master.Infrastructure.Names;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleContentB
{
    public class ContentBModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.CONTENT_REGION, typeof(ContentB));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ContentB>();
        }
    }
}
