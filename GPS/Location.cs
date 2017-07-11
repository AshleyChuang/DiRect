using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Device.Location;
using System.Diagnostics;

namespace GPS
{
    public class Location
    {

        GeoCoordinateWatcher watcher;
        private double latitude;
        private double longitude;
        public void GetLocationEvent()
        {
            this.watcher = new GeoCoordinateWatcher();
            this.watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
            bool started = this.watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));
           /* if (!started)
            {
                Console.WriteLine("GeoCoordinateWatcher timed out on start.");
            }*/
        }

        public double Longitude
        {
            get
            {
                Debug.WriteLine("Latitude: " + longitude);
                return longitude;
            }
        }
        public double Latitude
        { get {
                Debug.WriteLine("Latitude: " + latitude);
                return latitude;
            }
        }
        void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            Debug.WriteLine("Latitude 2: "+ e.Position.Location.Latitude.ToString());
            Debug.WriteLine("Longitude 2: " + e.Position.Location.Latitude.ToString());
            latitude = e.Position.Location.Latitude;
            longitude = e.Position.Location.Longitude;

            
        }

       
    }
}
