using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScreensInterfaces
{
    public class MenuViewBase: UserControl, IView
    {
        public event EventHandler UserEnteredInput;

        public event EventHandler ScreenTimedOut;

        public MenuViewBase()
        {
        }


        protected void RaiseUserInputReadyEvent(EventArgs e)
        {
            EventHandler handler = UserEnteredInput;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public virtual string WorkFlowName() {
            return "";
        }


    }
}
