using Prism.Commands;
using Prism.Regions;
using Prism7_Master.Infrastructure.Bases;
using Prism7_Master.Infrastructure.Names;
using System;
using Unity;

namespace ModuleMenu.ViewModels
{
    public class MenuViewModel : ViewModelBase, INavigationAware
    {
        #region Properties

        #endregion

        #region Commands
        public DelegateCommand ContentACommand { get; private set; }
        public DelegateCommand ContentBCommand { get; private set; }
        #endregion

        #region Constructor
        public MenuViewModel(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;

            ContentACommand = new DelegateCommand(LoadContentA);
            ContentBCommand = new DelegateCommand(LoadContentB);
        }
        #endregion

        #region Navigation
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }
        #endregion

        #region Commands Methods
        private void LoadContentA()
        {
            NavigationConfig(ModuleNames.CONTENT_MODULE, RegionNames.CONTENT_REGION, ViewNames.CONTENT);
        }

        private void LoadContentB()
        {
            NavigationConfig(ModuleNames.CONTENTB_MODULE, RegionNames.CONTENT_REGION, ViewNames.CONTENTB);
        }
        #endregion
    }
}
