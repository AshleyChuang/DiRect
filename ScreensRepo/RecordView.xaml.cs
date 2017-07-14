using ScreensInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ScreensRepo.Models;
using System.Diagnostics;
using GMap.NET;
using GPS;
using System.Windows.Controls.DataVisualization.Charting;
using System.Collections.ObjectModel;
using ScreensRepo.ViewModles;
using System.ComponentModel;
using System.Windows.Threading;
using Microsoft.Maps.MapControl;
using Microsoft.Maps.MapControl.WPF;
using System.Device.Location;
namespace ScreensRepo
{
    /// <summary>
    /// RecordView.xaml 的互動邏輯
    /// </summary>
    public partial class RecordView : MenuViewBase
    {
        GPS.Location mLocation;
        Microsoft.Maps.MapControl.WPF.Location currentLocation;
        bool IsMouseLeftButtonDown = false;
        //AreaDataPoint areaDataPoint;
        private LocationData Model;// { get; set; }
        public List<CauseOfDisaster> AvailablePresentationObjects { get; set; }
        
        public RecordView()
        {
            initializeCheckBox();
            this.DataContext = this;
            GeoCoordinateWatcher watcher;
            watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
            watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));

            //pushpins = new ObservableCollection<Pushpin>();
            this.DataContext = this;
            startclock();
            //locations = ListOfLocations.GetInstance();
            
            InitializeComponent();
            
        
            mapView.ZoomLevel = 17.0;
           
            DateTime dateNow = DateTime.Now;
   
            //waterlevel.Visibility = Visibility.Hidden;
            //Save_Button.Visibility = Visibility.Hidden;
        }

        private void initializeCheckBox()
        {
            PossibleCausesOfDisaster possiblecauses = PossibleCausesOfDisaster.GetInstance();
            AvailablePresentationObjects = new List<CauseOfDisaster>();
            for (int i=0; i<possiblecauses.causes.Count(); i++)
            {
                Debug.WriteLine(possiblecauses.causes[i]);
                AvailablePresentationObjects.Add(new CauseOfDisaster(i, possiblecauses.causes[i], false));
            }
        }

        void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            mapView.Center = new Microsoft.Maps.MapControl.WPF.Location(e.Position.Location.Latitude, e.Position.Location.Longitude);
            pushpin.Location = new Microsoft.Maps.MapControl.WPF.Location(e.Position.Location.Latitude, e.Position.Location.Longitude);
            Microsoft.Maps.MapControl.WPF.Location pinLocation = new Microsoft.Maps.MapControl.WPF.Location(e.Position.Location.Latitude, e.Position.Location.Longitude);
            LongitudeTextBox.Text = e.Position.Location.Longitude.ToString();
            LatitudeTextBox.Text = e.Position.Location.Latitude.ToString();
        }
        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }
        private void tickevent(Object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString();
        }
        // Map
       
        private void Click_On_Save_Button(object sender, EventArgs e)
        {
            ObservableCollection<string> causes = new ObservableCollection<string>();
            for (int i = 0; i < AvailablePresentationObjects.Count(); i++)
            {
                if (AvailablePresentationObjects[i].IsChecked == true)
                {
                    AvailablePresentationObjects[i].IsChecked = false;
                    Debug.WriteLine(AvailablePresentationObjects[i].Name);
                    causes.Add(AvailablePresentationObjects[i].Name);
                }
            }

            FloodsRecord record = RecordViewModel.SaveRecord("address", LatitudeTextBox.Text, LongitudeTextBox
                    .Text, TimeTextBox.Text, WaterLevelTextBox.Text, causes);
            if (WaterLevelTextBox.Text != "" && causes.Count()!=0) {
                Debug.WriteLine("click save button");
                WaterLevelTextBox.Text = "";
            }
            RaiseUserInputReadyEvent(new SaveButtonClickedEventArgs(record));
            
        }
        public override string WorkFlowName()
        {
            return "RecordWorkFlow";

        }
    }
}
