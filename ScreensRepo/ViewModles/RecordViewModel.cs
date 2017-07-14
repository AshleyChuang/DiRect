using ScreensRepo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensRepo.ViewModles
{
    public class RecordViewModel
    {
        public RecordViewModel()
        {


        }
        static public FloodsRecord SaveRecord(string address, string latitude, string longitude, string time, string waterLevel, ObservableCollection<string> causes)
        {
            FloodsRecord record = new FloodsRecord();
            record.Address = address;
            record.Latitude = latitude;
            record.Longitude = longitude;
            record.Time = time;
            record.WaterLevel = waterLevel;
            record.causes = causes;
            //AddToLocationList(locationID,time,waterLevel);
            return record;

        }

        static public void AddToLocationList(int locationID, string time, string waterLevel)
        {
            ListOfLocations locationList=ListOfLocations.GetInstance();
             Convert.ToDateTime(time);
            Debug.WriteLine("record2= "+ time+" "+ waterLevel);
            locationList.Locations[locationID].addWaterLevel(Convert.ToDateTime(time), Convert.ToDouble(waterLevel));


        }
    }
}
