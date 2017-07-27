using DiReCT_wpf.Helpers;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Device.Location;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace DiReCT_wpf.ViewModel
{
    public class OtherViewModel : ViewModelBase
    {
        private Microsoft.Maps.MapControl.WPF.Location currentLocation;
        public Microsoft.Maps.MapControl.WPF.Location CurrentLocation
        {

            get
            {
                if (currentLocation == null)
                {

                    return new Microsoft.Maps.MapControl.WPF.Location(23.041, 121.1232);
                }
                else
                {
                    Debug.WriteLine("PUSHPIN!!!!!!!!!!!!!!");
                    Debug.WriteLine(currentLocation.Latitude.ToString());
                    Debug.WriteLine(currentLocation.Longitude.ToString());
                    return currentLocation;
                }
            }
            set { }
        }
        public int deathTroll { get; set; }
        public int injuryTroll { get; set; }
        public ObservableCollection<bool> conditions { get; set; }
        public DateTime currentDateTime { get; set; }
        public string estimatedTimeStamp { get; set; }
        public string currentLongitude { get; set; }
        public string currentLatitude { get; set; }
        public string currentTimeStamp { get; set; }
        public object photoUploaded { get; set; }
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand UploadCommand { get; set; }
        public int condition { get; set; }
        public Microsoft.Maps.MapControl.WPF.MapLayer Layer { get; set; }
        public OtherViewModel()
        {
            GeoCoordinateWatcher watcher;
            watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
            watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));
            conditions = new ObservableCollection<bool>() { false, false, false, false, false };
            startclock();
            SaveCommand = new RelayCommand(DoSaveRecord);
            UploadCommand = new RelayCommand(LoadClick);
            currentDateTime = DateTime.Now;
            Layer = new Microsoft.Maps.MapControl.WPF.MapLayer();
            deathTroll = 0;
            injuryTroll = 0;
        }
        private void DoSaveRecord(object obj)
        {
            Debug.WriteLine("Save~~~");
            photoUploaded = null;
            Layer= new Microsoft.Maps.MapControl.WPF.MapLayer();
            for(int i=0; i<conditions.Count(); i++)
            {
                conditions[i] = false;
            }
            deathTroll = 0;
            injuryTroll = 0;
            RaisePropertyChanged("deathTroll");
            RaisePropertyChanged("injuryTroll");
            RaisePropertyChanged("photoUploaded");
            RaisePropertyChanged("saveRecord");
            RaisePropertyChanged("conditions");
        }
        private void LoadClick(object sender)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                //imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
                photoUploaded = new BitmapImage(new Uri(op.FileName));
                RaisePropertyChanged("photoUploaded");
            }

        }
        private void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            currentLocation = new Microsoft.Maps.MapControl.WPF.Location(e.Position.Location.Latitude, e.Position.Location.Longitude);
            currentLongitude = e.Position.Location.Longitude.ToString();
            currentLatitude = e.Position.Location.Latitude.ToString();
            RaisePropertyChanged("currentLongitude");
            RaisePropertyChanged("currentLatitude");
            RaisePropertyChanged("CurrentLocation");
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
            currentTimeStamp = DateTime.Now.ToString();
            RaisePropertyChanged("currentTimeStamp");
        }

        public override string Name
        {
            get
            {
                return "Other";
            }
        }
    }
    [Serializable]
    public enum TimeType { AM, PM }
}
