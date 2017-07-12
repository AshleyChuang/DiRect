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
        GPS.Location myLocation;
        bool IsMouseLeftButtonDown = false;
        AreaDataPoint areaDataPoint;
        private LocationData Model;// { get; set; }
        public ListOfLocations locations { get; set; }
        public ObservableCollection<WaterLevelTimeStamp> waterLevel { get; set; }
        public ObservableCollection<Pushpin> pushpins { get; set; }
        private int clickedPinTag = -1;
        public RecordView()
        {
            GeoCoordinateWatcher watcher;
            watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
            watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));

            pushpins = new ObservableCollection<Pushpin>();
            this.DataContext = this;
            startclock();
            locations = ListOfLocations.GetInstance();
            
            
            InitializeComponent();

        
            mapView.ZoomLevel = 17.0;
           
            addPushPin();

            myDateTimeAxis.Interval = 1.0/60.0;
            myDateTimeAxis.IntervalType = DateTimeIntervalType.Hours;
            DateTime dateNow = DateTime.Now;
            //myDateTimeAxis.Minimum = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 0, 0, 0);
            //myDateTimeAxis.Maximum = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 23, 59, 59);
            ScrollArea.Visibility = Visibility.Hidden;
            Timer.Visibility = Visibility.Hidden;
            coordinates.Visibility = Visibility.Hidden;
            waterlevel.Visibility = Visibility.Hidden;
            Save_Button.Visibility = Visibility.Hidden;
            myDateTimeAxis.Minimum = DateTime.Now.AddMinutes(-20);
            myDateTimeAxis.Maximum = DateTime.Now.AddMinutes(20);
            myLinearAxis.Maximum = 30.0;
            myLinearAxis.Minimum = 0;
            myLineSeries.ItemsSource = null;
        }
        void addPushPin()
        {
            for(int i=0; i<locations.Locations.Count(); i++)
            {
                Debug.WriteLine("i=", i);
                Debug.WriteLine(locations.Locations[i].Latitude);
                Debug.WriteLine(locations.Locations[i].Longitude);
                Microsoft.Maps.MapControl.WPF.Location pinLocation = new Microsoft.Maps.MapControl.WPF.Location(locations.Locations[i].Latitude, locations.Locations[i].Longitude);

                // The pushpin to add to the map.
                Pushpin pin = new Pushpin();
                pin.Tag = i.ToString();
                pin.Background = new SolidColorBrush(Color.FromRgb(0,0,200));
                pin.Location = pinLocation;
                pin.MouseLeftButtonDown += Click_On_Push_Pin;
                pushpins.Add(pin);
                mapView.Children.Add(pin);
            }
        }
        void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            mapView.Center = new Microsoft.Maps.MapControl.WPF.Location(e.Position.Location.Latitude, e.Position.Location.Longitude);
            Microsoft.Maps.MapControl.WPF.Location pinLocation = new Microsoft.Maps.MapControl.WPF.Location(e.Position.Location.Latitude, e.Position.Location.Longitude);
            LongitudeTextBox.Text = e.Position.Location.Longitude.ToString();
            LatitudeTextBox.Text = e.Position.Location.Latitude.ToString();
            Pushpin pin = new Pushpin();
            pin.Location = pinLocation;
            pin.MouseLeftButtonDown += Click_On_Push_Pin;
            pin.Tag = "-1";
            // Adds the pushpin to the map.
            mapView.Children.Add(pin);
        }
        
        // Timer
        private void Click_On_Push_Pin(object sender, EventArgs e)
        {
            Pushpin clickedPin = (Pushpin)sender;
            if (Convert.ToInt32(clickedPin.Tag) < 0)
            {
                return;
            }
            clickedPinTag = Convert.ToInt32(clickedPin.Tag);
            Debug.WriteLine("Click Push Pin");
            Debug.WriteLine(clickedPinTag);
            
            for (int i = 0; i < pushpins.Count(); i++)
                pushpins[i].Background = new SolidColorBrush(Color.FromRgb(0, 0, 200));
            ScrollArea.Visibility = Visibility.Visible;
            Timer.Visibility = Visibility.Visible;
            coordinates.Visibility = Visibility.Visible;
            waterlevel.Visibility = Visibility.Visible;
            Save_Button.Visibility = Visibility.Visible;
            clickedPin.Background = new SolidColorBrush(Color.FromRgb(2, 176, 0));
            waterLevel = locations.Locations[Convert.ToInt32(clickedPin.Tag)].WaterLevelTimeStamps;
            myLineSeries.ItemsSource = waterLevel;
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
            FloodsRecord record = RecordViewModel.SaveRecord(clickedPinTag, "address", LatitudeTextBox.Text, LongitudeTextBox
                    .Text, TimeTextBox.Text, WaterLevelTextBox.Text);
            if (WaterLevelTextBox.Text != "") {
                Debug.WriteLine("click save button");
                RecordViewModel.AddToLocationList(clickedPinTag,TimeTextBox.Text, WaterLevelTextBox.Text);

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
