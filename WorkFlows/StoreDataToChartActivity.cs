using System;
using System.Activities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreensRepo.ViewModles;
using ScreensRepo.Models;
using ScreensInterfaces;
namespace WorkFlows
{
    public sealed class StoreDataToChartActivity : NativeActivity<string>
    {
        public InArgument<object> RecordData { get; set; }

        protected override void Execute(NativeActivityContext context)
        {
            SaveButtonClickedEventArgs e = (SaveButtonClickedEventArgs)context.GetValue(this.RecordData);

            FloodsRecord record = (FloodsRecord)e.SavedRecord;
        }
    }
}
