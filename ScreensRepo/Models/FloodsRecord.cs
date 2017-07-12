using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensRepo.Models
{
    public class FloodsRecord
    {
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string WaterLevel { get; set; }
        public string Time { get; set; }
        public int LocationID { get; set; }
    }
}
