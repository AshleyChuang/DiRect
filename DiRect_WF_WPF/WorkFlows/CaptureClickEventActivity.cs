using ScreensInterfaces;
using ScreensRepo.Models;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlows
{
    public sealed class CaptureClickEventActivity : NativeActivity<string>
    {
        public InArgument<string> BookmarkName { get; set; }

        private string bookmarkName;
        public OutArgument<object> Record { get; set; }
        public OutArgument<string> NextWorkFlow { get; set; }
        private string nextWorkFlow;
        public OutArgument<string> NextState { get; set; }
        private string nextState;
        private object recordData;
        private IView recordView;
        private IView menuScreen;
        protected override void Execute(NativeActivityContext context)
        {
            bookmarkName = context.GetValue(this.BookmarkName);

            recordView = ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.ShowRecordView();
            menuScreen = ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.ShowMenuScreen();
            recordView.UserEnteredInput += OnInputReady;
            menuScreen.UserEnteredInput += OnInputReady;

            context.CreateBookmark(bookmarkName,
                new BookmarkCallback(OnResumeBookmark));
        }
        private void OnInputReady(object sender, EventArgs e)
        {

            if (e.GetType() == typeof(SaveButtonClickedEventArgs))
            {
                recordView.UserEnteredInput -= OnInputReady;
                menuScreen.UserEnteredInput -= OnInputReady;

                recordData = e;
                nextWorkFlow = "MainWorkFlow";
                nextState = "Authenticate Input Data";

                ServiceLocator.ServiceLocator.Instance.CurrentWorkFlow.ResumeBookmark(bookmarkName, e);
            }
            else if (e.GetType() == typeof(MouseOnMenuEventArgs))
            {
                recordView.UserEnteredInput -= OnInputReady;
                menuScreen.UserEnteredInput -= OnInputReady;
                nextWorkFlow = "MenuWorkFlow";
                nextState = "FinalState";
                ServiceLocator.ServiceLocator.Instance.CurrentWorkFlow.ResumeBookmark(bookmarkName, e);

            }

        }

        protected override bool CanInduceIdle
        {
            get { return true; }
        }

        public void OnResumeBookmark(NativeActivityContext context, Bookmark bookmark, object obj)
        {
            context.RemoveAllBookmarks();
            Debug.WriteLine("nextWorkFlow = "+ nextWorkFlow);
            NextState.Set(context, nextState);
            NextWorkFlow.Set(context, nextWorkFlow);
            Record.Set(context, recordData);



        }
    }
}
