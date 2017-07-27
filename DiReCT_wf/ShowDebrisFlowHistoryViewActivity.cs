using DiReCT_wpf.ScreenInterface;
using DiReCT_wpf.ViewModel;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT_wf
{
   
        public sealed class ShowDebrisFlowHistoryViewActivity : NativeActivity<string>
        {

            private IView mainView;

            protected override void Execute(NativeActivityContext context)
            {
                mainView = HomeScreenViewModel.GetInstance().ShowDFHistoryView();

            }

        }
    
}
