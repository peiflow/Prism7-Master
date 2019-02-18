using Prism.Regions;
using Prism7_Master.Infrastructure.Bases;
using System;
using Unity;

namespace ModuleMenu.ViewModels
{
    public class MenuViewModel : ViewModelBase, INavigationAware
    {
        public MenuViewModel(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }
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
    }
}
