using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT_wpf.Model
{
    public class FloodRecord
    {
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string WaterLevel { get; set; }
        public string Time { get; set; }
        public ObservableCollection<string> causes { get; set; }
    }
}
