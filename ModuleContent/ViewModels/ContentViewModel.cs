using Prism.Regions;
using Prism7_Master.Infrastructure.Bases;
using System;
using Unity;

namespace ModuleContent.ViewModules
{
    public class ContentViewModel : ViewModelBase, INavigationAware
    {
        #region Constructors
        public ContentViewModel(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }
        #endregion

        #region Navigation
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
