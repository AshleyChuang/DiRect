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
    public sealed class ShowMainViewActivity : NativeActivity<string>
    {
       
        private IView mainView;

        protected override void Execute(NativeActivityContext context)
        {              
            mainView = ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.ShowMainView();
     
        }
       
    }
}
