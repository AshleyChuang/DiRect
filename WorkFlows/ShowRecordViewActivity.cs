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
    public sealed class ShowRecordViewActivity : NativeActivity<string>
    
    {       
        private IView recordView;
      
        protected override void Execute(NativeActivityContext context)
        {         
            recordView = ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.ShowRecordView();
         
        }
       
    }
}
