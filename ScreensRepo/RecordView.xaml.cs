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
        int currLocation = 1;
        public ObservableCollection<WaterLevelTimeStamp> waterLevel { get; set; }
        
        public RecordView()
        {
            GeoCoordinateWatcher watcher;
            watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
            watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));


            this.DataContext = this;
            startclock();
            locations = ListOfLocations.GetInstance();
            waterLevel = locations.Locations[currLocation].WaterLevelTimeStamps;

            /*myLocation = new GPS.Location();
            myLocation.GetLocationEvent();*/

            InitializeComponent();

        
            mapView.ZoomLevel = 17.0;

            //Convert the mouse coordinates to a locatoin on the map
            Microsoft.Maps.MapControl.WPF.Location pinLocation = new Microsoft.Maps.MapControl.WPF.Location(24.25, 121.142);

            // The pushpin to add to the map.
            Pushpin pin = new Pushpin();
            pin.Location = pinLocation;
            pin.MouseLeftButtonDown += Click_On_Push_Pin;

            // Adds the pushpin to the map.
            mapView.Children.Add(pin);


            Model = locations.Locations[currLocation];

            myDateTimeAxis.Interval = 0.5;
            myDateTimeAxis.IntervalType = DateTimeIntervalType.Hours;
            DateTime dateNow = DateTime.Now;
            myDateTimeAxis.Minimum = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 0, 0, 0);
            myDateTimeAxis.Maximum = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 23, 59, 59);
            myLinearAxis.Maximum = Model.WaterLevelTimeStamps.Max(i => i.Value) + 5;
        }
        void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            Debug.WriteLine("Latitude 2: " + e.Position.Location.Latitude.ToString());
            Debug.WriteLine("Longitude 2: " + e.Position.Location.Latitude.ToString());
            mapView.Center = new Microsoft.Maps.MapControl.WPF.Location(e.Position.Location.Latitude, e.Position.Location.Longitude);
            Microsoft.Maps.MapControl.WPF.Location pinLocation = new Microsoft.Maps.MapControl.WPF.Location(e.Position.Location.Latitude, e.Position.Location.Longitude);
            LongitudeTextBox.Text = e.Position.Location.Longitude.ToString();
            LatitudeTextBox.Text = e.Position.Location.Latitude.ToString();
            Pushpin pin = new Pushpin();
            pin.Location = pinLocation;
            pin.MouseLeftButtonDown += Click_On_Push_Pin;

            // Adds the pushpin to the map.
            mapView.Children.Add(pin);
        }
        // Timer
        private void Click_On_Push_Pin(object sender, EventArgs e)
        {
            Debug.WriteLine("Click Push Pin");

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

            Debug.WriteLine("click save button");
            FloodsRecord record = RecordViewModel.SaveRecord("address", LatitudeTextBox.Text, LongitudeTextBox
                .Text, TimeTextBox.Text, WaterLevelTextBox.Text);
         

            RaiseUserInputReadyEvent(new SaveButtonClickedEventArgs(record));

        }
        public override string WorkFlowName()
        {
            return "RecordWorkFlow";

        }
        // Chart
        private void LineSeriesDataPoint_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            areaDataPoint = sender as AreaDataPoint;
            IsMouseLeftButtonDown = true;
        }
        private WaterLevelTimeStamp getMouseTransformData()
        {
            var p = Mouse.GetPosition(this.myLineSeries);
            var left = Model.WaterLevelTimeStamps.Min(i => i.Date);
            var right =  Model.WaterLevelTimeStamps.Max(i => i.Date);
            var top = Model.WaterLevelTimeStamps.Max(i => i.Value);
            var bottom = Model.WaterLevelTimeStamps.Min(i => i.Value);

            var hRange = right - left;
            var vRange = top - bottom;

            //ranges in the pixels
            var width = this.myLineSeries.ActualWidth;
            var height = this.myLineSeries.ActualHeight;

            //from the pixels to the real value
            var currentX = left + TimeSpan.FromTicks((long)(hRange.Ticks * p.X / width));
            var currentY = top - vRange * p.Y / height;

            return new WaterLevelTimeStamp(currentX, currentY);
        }
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseLeftButtonDown && e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                var dataPoint = getMouseTransformData();
                var a = Model.WaterLevelTimeStamps.Where(i => i.Date == (DateTime)areaDataPoint.IndependentValue);
                var index =  Model.WaterLevelTimeStamps.IndexOf(a.First());
                Model.WaterLevelTimeStamps[index] = new WaterLevelTimeStamp((DateTime)areaDataPoint.IndependentValue, (int)dataPoint.Value);
            }
        }
        private void chart1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            IsMouseLeftButtonDown = false;
        }
    }
}
