using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ScreensInterfaces;
using ScreensRepo.Models;
using System.Windows.Forms;
using System.Diagnostics;

namespace ScreensRepo
{
    /// <summary>
    /// MenuScreen.xaml 的互動邏輯
    /// </summary>
    public partial class MenuScreen : ScreenBase
    {
        public MenuScreen()
        {
            InitializeComponent();
          
        }

        private void ListBoxMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Object seletedMenuItem = ListBoxMenu.SelectedItem;
            if (seletedMenuItem != null) {
                
                RaiseUserInputReadyEvent(new MenuItemSelectedEventArgs(seletedMenuItem));
              
            }       
        }

        private void CurrentMenuView_MouseEnter(object sender, EventArgs e)
        {
            Debug.WriteLine("Mouse on the View");
            RaiseUserInputReadyEvent(new MouseOnViewEventArgs());

        }

        private void ListBoxMenu_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            RaiseUserInputReadyEvent(new MouseOnMenuEventArgs());
        }

      
    }
}
