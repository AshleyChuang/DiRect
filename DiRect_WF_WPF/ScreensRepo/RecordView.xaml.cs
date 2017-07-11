﻿using ScreensInterfaces;
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
namespace ScreensRepo
{
    /// <summary>
    /// RecordView.xaml 的互動邏輯
    /// </summary>
    public partial class RecordView : MenuViewBase
    {
        Location myLocation;
        bool IsMouseLeftButtonDown = false;
        AreaDataPoint areaDataPoint;
        private LocationData Model;// { get; set; }
        public ListOfLocations locations { get; set; }
        int currLocation = 1;
        public ObservableCollection<WaterLevelTimeStamp> waterLevel { get; set; }
        public RecordView()
        {
            this.DataContext = this;
            locations = ListOfLocations.GetInstance();
            waterLevel = locations.Locations[currLocation].WaterLevelTimeStamps;
            myLocation = new Location();
            myLocation.GetLocationEvent();
            InitializeComponent();
            DateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
            Model = locations.Locations[currLocation];
            myDateTimeAxis.Interval = 0.5;
            myDateTimeAxis.IntervalType = DateTimeIntervalType.Hours;
            DateTime dateNow = DateTime.Now;
            myDateTimeAxis.Minimum = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 0, 0, 0);
            myDateTimeAxis.Maximum = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 23, 59, 59);
            //myDateTimeAxis.Minimum = Model.WaterLevelTimeStamps.Min(i => i.Date).AddHours(-1);
            //myDateTimeAxis.Maximum = Model.WaterLevelTimeStamps.Max(i => i.Date).AddHours(1);
            myLinearAxis.Maximum = Model.WaterLevelTimeStamps.Max(i => i.Value) + 5;
        }
        private void LineSeriesDataPoint_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            areaDataPoint = sender as AreaDataPoint;
            IsMouseLeftButtonDown = true;
        }
        private void mapView_Loaded(object sender, RoutedEventArgs e)
        {

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            // choose your provider here
            mapView.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            mapView.MinZoom = 2;
            mapView.MaxZoom = 17;
            // whole world zoom
            mapView.Zoom = 17;
            // lets the map use the mousewheel to zoom
            mapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            // lets the user drag the map
            mapView.CanDragMap = true;
            // lets the user drag the map with the left mouse button
            mapView.DragButton = MouseButton.Left;
            mapView.Position = new PointLatLng(myLocation.Latitude, myLocation.Longitude);
            LatitudeTextBox.Text = myLocation.Latitude.ToString();
            LongitudeTextBox.Text = myLocation.Longitude.ToString();

        }


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