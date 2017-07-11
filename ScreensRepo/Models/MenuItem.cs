using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreensInterfaces;
namespace ScreensRepo.Models
{
   public class MenuItem
    {
       
        private string lable;

        public MenuItem(string l)
        {
            this.lable = l;
        }

       
        public string Lable
        {
            get { return lable; } 
        }
       
    }
}
