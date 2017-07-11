using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;

namespace ScreensInterfaces
{
    public interface IRepresentationLayer: INotifyPropertyChanged
    {
        ScreenBase CurrentScreen { get; }
        MenuViewBase CurrentMenuView { get; }

        ScreenBase ShowLoginScreen();
        ScreenBase ShowMenuScreen();
        MenuViewBase ShowMainView();
        MenuViewBase ShowOtherView();
        MenuViewBase ShowRecordView();

        void ShowNotificationWindow(string notifacation);
    }
}
