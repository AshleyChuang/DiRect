using ScreensRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensRepo.ViewModles
{
    class RecordViewModel
    {
        public RecordViewModel()
        {


        }
        static public FloodsRecord SaveRecord(string address, string latitude, string longitude, string time, string waterLevel)
        {
            FloodsRecord record = new FloodsRecord();
            record.Address = address;
            record.Latitude = latitude;
            record.Longitude = longitude;
            record.Time = time;
            record.WaterLevel = waterLevel;
            AddToLocationList(1,time,waterLevel);
            return record;

        }

        static private void AddToLocationList(int locationID, string time, string waterLevel)
        {
            ListOfLocations locationList=ListOfLocations.GetInstance();
             Convert.ToDateTime(time);
        
            locationList.Locations[1].addWaterLevel(Convert.ToDateTime(time), Convert.ToDouble(waterLevel));


        }
    }
}
