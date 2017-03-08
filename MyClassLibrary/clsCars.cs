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






        public bool Find(Int32 CarID)        
        {
            //Create an instance of the data connection.
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the CarID to search for.
            DB.AddParameter("@CarID", CarID);
            //Execute stored procedure.
            DB.Execute("sproc_tblCars_FilterByCarID");
            //If one record is found (There should be 1 or 0)
            if (DB.Count == 1)
            {
                //Copy Data from the database to the private data members.
                mCarManufacturer = Convert.ToString(DB.DataTable.Rows[0]["CarManufacturer"]);
                mCarModel = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
                mCarColour = Convert.ToString(DB.DataTable.Rows[0]["CarColour"]);
                mCarRegistration = Convert.ToString(DB.DataTable.Rows[0]["CarRegistrationPlate"]);
                mCarNeedsRepair = Convert.ToBoolean(DB.DataTable.Rows[0]["CarNeedsRepair"]);
                mCarNumberOfDoors = Convert.ToInt32(DB.DataTable.Rows[0]["NumOfDoors"]);
                mCarNumberOfSeats = Convert.ToInt32(DB.DataTable.Rows[0]["NumOfSeats"]);
                mCarSold = Convert.ToBoolean(DB.DataTable.Rows[0]["CarSold"]);
                //return that everything worked okay.
                return true;
            }
            //if no record wa found
            else
            {
                //return false, indicating a problem
                return false;
            }
        }
    }
}