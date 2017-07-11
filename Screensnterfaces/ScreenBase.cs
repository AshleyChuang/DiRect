using System.Windows.Controls;
using System;
using System.Timers;

namespace ScreensInterfaces
{
    public class ScreenBase:UserControl,IView
    {
        public event EventHandler UserEnteredInput;

        public event EventHandler ScreenTimedOut;

        public ScreenBase()
        {
        }
    

        protected void RaiseUserInputReadyEvent(EventArgs e)
        {
            EventHandler handler = UserEnteredInput;
            if (handler != null)
            {
                handler(this,e);
            }
        }


    }
}
