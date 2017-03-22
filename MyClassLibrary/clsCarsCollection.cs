using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCarsCollection
    {
        //private data member for the list.
        List<clsCar> mCarList = new List<clsCar>();

        public clsCarsCollection()
        {
            //Variable for index
            Int32 Index = 0;
            //variable to store the record count.
            Int32 RecordCount = 0;
            //Object for data connection.
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure.
            DB.Execute("sproc_tblCars_SelectAll");
            //Get the count of records.
            RecordCount = DB.Count;
            //While there a records to process.
            while (Index < RecordCount)
            {
                //Create a blank class
                clsCar AnCar = new clsCar();
                //read in the fields from the current record.
                AnCar.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                AnCar.CarManufacturer = Convert.ToString(DB.DataTable.Rows[Index]["CarManufacturer"]);
                AnCar.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AnCar.CarRegistrationPlate = Convert.ToString(DB.DataTable.Rows[Index]["CarRegistrationPlate"]);
                AnCar.CarColour = Convert.ToString(DB.DataTable.Rows[Index]["CarColour"]);
                AnCar.CarNumberOfDoors = Convert.ToInt32(DB.DataTable.Rows[Index]["NumOfDoors"]);
                AnCar.CarNumberOfSeats = Convert.ToInt32(DB.DataTable.Rows[Index]["NumOfSeats"]);
                AnCar.TransactionID = Convert.ToInt32(DB.DataTable.Rows[Index]["TransactionID"]);
                AnCar.CarNeedsRepair = Convert.ToBoolean(DB.DataTable.Rows[Index]["CarNeedsRepair"]);
                AnCar.CarSold = Convert.ToBoolean(DB.DataTable.Rows[Index]["CarSold"]);
                //add the record to the private data member.
                mCarList.Add(AnCar);
                //Point at the next record
                Index++;
            }


        }

        public List<clsCar> CarList
        {
            get
            { 
                //Return the private data
                return mCarList;
            }
            set
            {
                //set the private data
                mCarList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list.
                return mCarList.Count;
            }
            set
            {
                //worry about this later.
            }
        }
        public clsCar ThisCar { get; set; }
    }
}