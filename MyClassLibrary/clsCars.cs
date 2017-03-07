using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class clsCar
    {
        //private data member for the manufacturer property.
        private string mCarManufacturer;
        private string mCarModel;
        private string mCarColour;

        public string CarColour
        {
            get
            //return the private data.
            { return mCarColour; }

            set
            //set the value pf the private data member.
            { mCarColour = value; }
        }
        //public property for the manufacturer.
        public string CarManufacturer
        {
            get
                //return the private data.
            { return mCarManufacturer; }

            set
                //set the value pf the private data member.
            { mCarManufacturer = value; }
        }

        public string CarModel
        {
            get
            //return the private data.
            { return mCarModel; }

            set
            //set the value pf the private data member.
            { mCarModel = value; }
        }
        public bool CarNeedsRepair { get; set; }
        public int CarNumberOfDoors { get; set; }
        public int CarNumberOfSeats { get; set; }
        public string CarRegistrationPlate { get; set; }
        public bool CarSold { get; set; }



        public bool Find(string CarManufactuer)        
        {
            //set the private data member to test the data value.
            mCarManufacturer = "Audi";
            mCarModel = "Test Model";
            mCarColour = "Test Colour";
            //always return true.
            return true;
        }
    }
}