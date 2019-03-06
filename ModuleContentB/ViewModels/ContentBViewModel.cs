using Prism.Commands;
using Prism.Regions;
using Prism7_Master.Helpers;
using Prism7_Master.Infrastructure.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ModuleContentB.ViewModels
{
    public class ContentBViewModel : ViewModelBase, INavigationAware
    {
        #region Properties
        ErrorEventHelper errorEventHelper;

        public DelegateCommand MakeThingsCmd { get; private set; }

        private string labelText;
        public string LabelText { get => labelText; set { labelText = value; RaisePropertyChanged("LabelText"); } }

        
        #endregion

        #region Constructor
        public ContentBViewModel(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;

            LabelText = "TEXT";

            errorEventHelper = new ErrorEventHelper();
            MakeThingsCmd = new DelegateCommand(MakeThings);
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

        #region Cmds
        private void MakeThings()
        {
            errorEventHelper.RaiseError(this, new CustomEventArgs { Info = "Shit happens"});
        }
        #endregion
    }
}
