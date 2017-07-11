using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using ScreensInterfaces;
using ScreensRepo.Models;
using System.Diagnostics;

namespace WorkFlows
{
    public sealed class ReceiveSignalsActivity : NativeActivity<string>
    {
        [RequiredArgument]

        public InArgument<string> BookmarkName { get; set; }

        private string bookmarkName;
        public OutArgument<string> NextWorkFlow { get; set; }

        private string nextWorkFlow;
        public OutArgument<string> NextState { get; set; }
        private string nextState;

        private IView menuScreen;

        protected override void Execute(NativeActivityContext context)
        {
            Debug.WriteLine("In MenuWorkFlow");
            menuScreen = ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.ShowMenuScreen();
            menuScreen.UserEnteredInput += OnInputReady;

            if (ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.CurrentMenuView != null)
            {
                nextWorkFlow = ServiceLocator.ServiceLocator.Instance.RepresentationLayerMain.CurrentMenuView.WorkFlowName();

            }

            bookmarkName = context.GetValue(this.BookmarkName);
            context.CreateBookmark(bookmarkName,
                new BookmarkCallback(OnResumeBookmark));

        }
        private void OnInputReady(object sender, EventArgs e)
        {


            if (e.GetType() == typeof(MenuItemSelectedEventArgs))
            {
                menuScreen.UserEnteredInput -= OnInputReady;

                MenuItemSelectedEventArgs menuEventArgs = e as MenuItemSelectedEventArgs;
                MenuItem menuItem = menuEventArgs.SelectedItem as MenuItem;
                nextState = menuItem.Lable;
                ServiceLocator.ServiceLocator.Instance.CurrentWorkFlow.ResumeBookmark(bookmarkName, null);
            }
            else if (e.GetType() == typeof(MouseOnViewEventArgs))
            {
                menuScreen.UserEnteredInput -= OnInputReady;
                nextState = "FinalState";
                ServiceLocator.ServiceLocator.Instance.CurrentWorkFlow.ResumeBookmark(bookmarkName, null);
            }

        }
        protected override bool CanInduceIdle
        {
            get { return true; }
        }

        public void OnResumeBookmark(NativeActivityContext context, Bookmark bookmark, object obj)
        {
            context.RemoveAllBookmarks();

            NextState.Set(context, nextState);
            NextWorkFlow.Set(context, nextWorkFlow);
        }
    }
}
