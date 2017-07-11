using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensRepo.Models
{
    public class ListOfLocations
    {
        public ObservableCollection<LocationData> Locations { get; set; }
        public ListOfLocations()
        {
            Locations = new ObservableCollection<LocationData>()
            {
                new LocationData()
                {
                    Longitude = 25.0321,
                    Latitude = 121.123
                },
                new LocationData()
                {
                    Longitude = 25.08123,
                    Latitude = 120.1123
                },
                new LocationData()
                {
                    Longitude = 24.987,
                    Latitude = 120.543
                }
            };
            Locations[1].addWaterLevel(DateTime.Now, 30.0);
            Locations[1].addWaterLevel(DateTime.Now.AddHours(0.5), 10.8);
        }
        static ListOfLocations _instance;

        public static ListOfLocations GetInstance()
        {
            if (_instance == null)
                _instance = new ListOfLocations();
            return _instance;
        }
    }
}
