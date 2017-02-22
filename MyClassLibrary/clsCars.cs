using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class clsCar
    {
        public string CarColour { get; set; }
        public string CarManufacturer { get; set; }
        public string CarModel { get; set; }
        public bool CarNeedsRepair { get; set; }
        public int CarNumberOfDoors { get; set; }
        public int CarNumberOfSeats { get; set; }
        public string CarRegistrationPlate { get; set; }
        public bool CarSold { get; set; }



        public bool Find(string CarManufactuer)
        {
            return true;
        }
    }
}