using ScreensInterfaces;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlows
{
    public sealed class ShowNotificationActivity : NativeActivity<string>
    {
        public InArgument<string> Notification { get; set; }

        protected override void Execute(NativeActivityContext context)
        {
            string notification = context.GetValue(this.Notification);
            Debug.WriteLine("Show Notification : " + notification);
            ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.ShowNotificationWindow(notification);


        }
    }
        
}
