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
    public sealed class ShowOtherViewActivity:NativeActivity<string>
    {
    
        private IView screen;

        protected override void Execute(NativeActivityContext context)
        {
           
            screen = ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.ShowOtherView();        
      
        }
      
    }
}
