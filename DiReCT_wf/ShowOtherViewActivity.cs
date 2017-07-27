﻿using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiReCT_wpf.ScreenInterface;
using DiReCT_wpf.ServiceLocator;
using DiReCT_wpf.ViewModel;
using System.Diagnostics;

namespace DiReCT_wf
{
    public sealed class ShowOtherViewActivity : NativeActivity<string>
    {

        private IView screen;

        protected override void Execute(NativeActivityContext context)
        {
            Debug.WriteLine("Show Other View Activity");
            HomeScreenViewModel.GetInstance().ShowOtherView();

        }

    }
}