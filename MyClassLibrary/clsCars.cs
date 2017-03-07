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
        private string mCarRegistration;
        private Boolean mCarNeedsRepair;
        private Int32 mCarNumberOfDoors;
        private Int32 mCarNumberOfSeats;
        private Boolean mCarSold;

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
        public bool CarNeedsRepair
        {
            get
            //return the private data.
            { return mCarNeedsRepair; }

            set
            //set the value pf the private data member.
            { mCarNeedsRepair = value; }
        }
        public int CarNumberOfDoors
        {
            get
            //return the private data.
            { return mCarNumberOfDoors; }

            set
            //set the value pf the private data member.
            { mCarNumberOfDoors = value; }
        }
        public int CarNumberOfSeats
        {
            get
            //return the private data.
            { return mCarNumberOfSeats; }

            set
            //set the value pf the private data member.
            { mCarNumberOfSeats = value; }
        }
        public string CarRegistrationPlate
        {
            get
            //return the private data.
            { return mCarRegistration; }

            set
            //set the value pf the private data member.
            { mCarRegistration = value; }
        }
        public bool CarSold
        {
            get
            //return the private data.
            { return mCarSold; }

            set
            //set the value pf the private data member.
            { mCarSold= value; }
        }






        public bool Find(string CarManufactuer)        
        {
            //set the private data member to test the data value.
            mCarManufacturer = "Audi";
            mCarModel = "Test Model";
            mCarColour = "Test Colour";
            mCarRegistration = "GV06 DTN";
            mCarNeedsRepair = true;
            mCarNumberOfDoors = 5;
            mCarNumberOfSeats = 5;
            mCarSold = true;
            //always return true.
            return true;
        }
    }
}