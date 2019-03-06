using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prism7_Master.Helpers
{
    public class ErrorEventHelper
    {
        delegate void OnErrorDg(object sender, CustomEventArgs e);
        OnErrorDg OnErrorEvent;

        public ErrorEventHelper()
        {
            OnErrorEvent += RaiseError;
        }

        public void RaiseError(object sender, CustomEventArgs e)
        {
            MessageBox.Show(e.Info, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    public class CustomEventArgs : EventArgs
    {
        public string Info { get; set; }
    }
}
