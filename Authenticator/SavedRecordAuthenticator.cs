using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreensRepo.Models;
using ScreensInterfaces;
using System.Diagnostics;

namespace Authenticator
{
    public class SavedRecordAuthenticator
    {
        private FloodsRecord record;
         
        public SavedRecordAuthenticator(Object r) {
            SaveButtonClickedEventArgs e =  (SaveButtonClickedEventArgs)r;
           
            record = (FloodsRecord)e.SavedRecord;
        }

        public string Authenticate() {
            string address = record.Address;
            string waterLevelString = record.WaterLevel;
            double waterLevelDouble;
            Debug.WriteLine("address = "+ address);
            Debug.WriteLine("waterLevel = "+ waterLevelString);
            if (String.IsNullOrEmpty(address)) {
                
                return "Please fill in address.";
            }
            else if (String.IsNullOrEmpty(waterLevelString)) {
               
                return "Please fill in water level.";
            }
           

            try
            {
                waterLevelDouble = Convert.ToDouble(waterLevelString);
           
            }
            catch (FormatException)
            {
                return "The foramat of water level is incorrect.";
            }
            catch (OverflowException)
            {
                return "The value of water level is outside the range.";
            }

         

            return "sucess";
        }
    }
}
