using Prism.Commands;
using Prism.Regions;
using Prism7_Master.Infrastructure.Bases;
using Prism7_Master.Infrastructure.Names;
using Names = Prism7_Master.Infrastructure.Names;

namespace Prism7_Master.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        #region Properties
        private readonly IRegionManager _regionManager;

        public DelegateCommand<object> NavigateCommand { get; private set; }

        public string Title { get => "Shell";}
        #endregion

        #region Constructor
        public ShellViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<object>(Navigate);
        }
        #endregion

        #region Navigation
        private void Navigate(object navigatePath)
        {
            if (navigatePath != null)
            {
                _regionManager.RequestNavigate(Names.RegionNames.CONTENT_REGION, navigatePath.ToString(), NavigationComplete);
            }
        }

        private void NavigationComplete(NavigationResult result)
        {

        }
        #endregion
    }
}
