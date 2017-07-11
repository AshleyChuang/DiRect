using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using ScreensInterfaces;
using ServiceLocator;
using System.Diagnostics;

namespace WorkFlows
{
    public sealed class ShowLoginActivity : NativeActivity<string>
    {
        public InArgument<string> BookmarkName { get; set; }
        private string bookmarkName;
        public OutArgument<string> NextWorkFlow { get; set; }
        private string nextWorkFlow;

        private IView loginScreen;
      
        protected override void Execute(NativeActivityContext context)
        {
           
            loginScreen = ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.ShowLoginScreen();   
            loginScreen.UserEnteredInput += OnInputReady;
            bookmarkName = context.GetValue(this.BookmarkName);

            context.CreateBookmark(bookmarkName,
                new BookmarkCallback(OnResumeBookmark));
           
        }

        private void OnInputReady(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(LoginButtonClickedEventArgs)) {
                loginScreen.UserEnteredInput -= OnInputReady;
                nextWorkFlow = "Menu";            
                ServiceLocator.ServiceLocator.Instance.CurrentWorkFlow.ResumeBookmark(bookmarkName, null);
            }
          
        }

        protected override bool CanInduceIdle
        {
            get { return true; }
        }

        public void OnResumeBookmark(NativeActivityContext context, Bookmark bookmark,object obj)
        {
            NextWorkFlow.Set(context,nextWorkFlow);
            context.RemoveAllBookmarks();
        }

    }
}
