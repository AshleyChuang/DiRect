using ScreensInterfaces;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authenticator;
namespace WorkFlows
{
    public sealed class AuthenticateActivity : NativeActivity<string>
    {
       
        public InArgument<object> RecordData { get; set; }
        public OutArgument<string> NextState { get; set; }
        private string nextState;
        private string message;
       
        protected override void Execute(NativeActivityContext context)
        {

            SavedRecordAuthenticator authenticator = new SavedRecordAuthenticator(context.GetValue(this.RecordData));
            message = authenticator.Authenticate();
            if (message == "sucess")
            {
                nextState = "ShowSucessNotification";
            }
            else {
                nextState = "ShowErrorNotification";
            }
            NextState.Set(context, nextState);  
            Result.Set(context, message);
            

        }
      
    }
}
