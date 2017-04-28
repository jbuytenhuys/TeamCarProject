using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class clsCar
    {
        //private data member
        private Int32 mSupplierID;
        private Int32 mCarID;
        private string mCarManufacturer;
        private string mCarModel;
        private string mCarColour;
        private string mCarRegistration;
        private Boolean mCarNeedsRepair;
        private Int32 mCarNumberOfDoors;
        private Int32 mCarNumberOfSeats;
        private Boolean mCarSold;

        public Int32 SupplierID
        {
            get
            //return the private data.
            { return mSupplierID; }

            set
            //set the value pf the private data member.
            { mSupplierID = value; }
        }

        public Int32 CarID
        {
            get
            //return the private data.
            { return mCarID; }

            set
            //set the value pf the private data member.
            { mCarID = value; }
        }

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
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
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

        public bool Valid(string CarManufacturer, string CarModel, string CarRegistrationPlate, string CarColour, string NumOfDoors, string NumOfSeats, string SupplierID)
        {
            //create a boolean variable to flag error
            Boolean OK = true;
            //if the Manufacturer is blank
            if (CarManufacturer.Length == 0)
            {
                //set the flag to OK to false
                OK = false;
            }
            //if the manufacturer is greater than 32 characters.
            if (CarManufacturer.Length > 32)
            {
                //set the flag to OK to false
                OK = false;
            }
            //if the car model is blank
            if (CarModel.Length == 0)
            {
                //set the flag to OK to false
                OK = false;
            }
            //if the  car model is greater than 32 characters.
            if (CarModel.Length > 32)
            {
                //set the flag to OK to false
                OK = false;
            }
            //if the CarRegistrationPlate is blank
            if (CarRegistrationPlate.Length == 0)
            {
                //set the flag to OK to false
                OK = false;
            }
            //if the  CarRegistrationPlate is greater than 8 characters.
            if (CarRegistrationPlate.Length > 8)
            {
                //set the flag to OK to false
                OK = false;
            }
            
            //if the CarColour is blank
            if (CarColour.Length == 0)
            {
                //set the flag to OK to false
                OK = false;
            }
            //if the CarColour is greater than 8 characters.
            if (CarColour.Length > 32)
            {
                //set the flag to OK to false
                OK = false;
            }
            
            int value;
            if (int.TryParse(NumOfDoors, out value))
            {
                if (Convert.ToInt32(NumOfDoors) < 2 | Convert.ToInt32(NumOfDoors) > 5)
                {
                    //set the flag to OK to false
                    OK = false;
                }
            }
            else 
             {
                OK = false;
            }


            if (int.TryParse(NumOfSeats, out value))
            {
                if (Convert.ToInt32(NumOfSeats) < 1 | Convert.ToInt32(NumOfSeats) > 7)
                {
                    //set the flag to OK to false
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            if (int.TryParse(SupplierID, out value))
            {
                
            }
            else
            {
                OK = false;
            }

            return OK;









        }



    }
}