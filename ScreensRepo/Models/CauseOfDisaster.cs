using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensRepo.Models
{
    public class CauseOfDisaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }
        public CauseOfDisaster(int Id, string name, bool IsChecked)
        {
            this.Id = Id;
            this.Name = name;
            this.IsChecked = IsChecked;
        }
    }
}
