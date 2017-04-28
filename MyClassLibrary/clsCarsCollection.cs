using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCarsCollection
    {
        
        //private data member for the list.
        List<clsCar> mCarList = new List<clsCar>();
        //private data member for thisCar
        clsCar mThisCar = new clsCar();

        public clsCarsCollection()
        {
            //Object for data connection.
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure.
            DB.Execute("sproc_tblCars_SelectAll");
            //populate array list with data table.
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarManufacturer", mThisCar.CarManufacturer);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarRegistrationPlate", mThisCar.CarRegistrationPlate);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@NumOfDoors", mThisCar.CarNumberOfDoors);
            DB.AddParameter("@NumOfSeats", mThisCar.CarNumberOfSeats);
            DB.AddParameter("@SupplierID", mThisCar.SupplierID);
            DB.AddParameter("@CarNeedsRepair", mThisCar.CarNeedsRepair);
            DB.AddParameter("CarSold", mThisCar.CarSold);          
            //Execute the query returning the primary key value.
            return DB.Execute("sproc_tblCars_Insert");
        }

        public Boolean CarRegistrationExists()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarRegistrationPlate", mThisCar.CarRegistrationPlate);
            return Convert.ToBoolean(DB.Execute("sproc_tblCars_RegistrationExists"));
        }

        public void Delete()
        {
            //Deletes the record pointed to by ThisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure.
            DB.AddParameter("@CarID", mThisCar.CarID);
            //Execute the stored procedure.
            DB.Execute("sproc_tblCars_Delete");
        }

        public void ArchiveAndDelete()
        {
            Boolean Sold = true;
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure.
            DB.AddParameter("@CarID", mThisCar.CarID);
            DB.AddParameter("@CarSold", Sold);
            DB.AddParameter("@CarRegistrationPlate", mThisCar.CarRegistrationPlate);
            //Execute the stored procedures.
            DB.Execute("sproc_tblCars_tblArchive_ArchiveAndDelete");
        }

        public void Update()
        {
            //update an existing record based on the values of this address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure.
            DB.AddParameter("@CarID", mThisCar.CarID);
            DB.AddParameter("@CarManufacturer", mThisCar.CarManufacturer);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarRegistrationPlate", mThisCar.CarRegistrationPlate);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@NumOfDoors", mThisCar.CarNumberOfDoors);
            DB.AddParameter("@NumOfSeats", mThisCar.CarNumberOfSeats);
            DB.AddParameter("@CarNeedsRepair", mThisCar.CarNeedsRepair);
            DB.AddParameter("@CarSold", mThisCar.CarSold);
            //Execute the stored procedure.
            DB.Execute("sproc_tblCars_Update");
        }

        public void FilterByCarManufacturer(string CarManufacturer)
        {
            //filters the records based on a full or partial car manufacturer.
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the car Manufacturer parameter to the database
            DB.AddParameter("@CarManufacturer", CarManufacturer);
            //Execute stored procedure.
            DB.Execute("sproc_tblCars_FilterByManufacturer");
            //populate array list with table data.
            PopulateArray(DB);
        }

        //WRITTEN BY JAKE FOR HIS SYSTEM AND ALSO USED BY ZADS
        public void FilterByRegPlate(string CarRegistrationPlate)
        {
            //filters the records based on a full or partial car manufacturer.
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the car Manufacturer parameter to the database
            DB.AddParameter("@CarRegistrationPlate", CarRegistrationPlate);
            //Execute stored procedure.
            DB.Execute("sproc_tblCars_FilterByCarRegistrationPlate");
            //populate array list with table data.
            PopulateArray(DB);
        }

        
        

        public void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //Variable for index
            Int32 Index = 0;
            //Variable to store the record count.
            Int32 RecordCount;
            RecordCount = DB.Count;
            //clear the private list array.
            mCarList = new List<clsCar>();
            //while there are records to process
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
                AnCar.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AnCar.CarNeedsRepair = Convert.ToBoolean(DB.DataTable.Rows[Index]["CarNeedsRepair"]);
                AnCar.CarSold = Convert.ToBoolean(DB.DataTable.Rows[Index]["CarSold"]);
                //add the record to the private data member.
                mCarList.Add(AnCar);
                //Point at the next record
                Index++;
            }
        }



        //public property for ThisCar
        public clsCar ThisCar
        {
            get
            {
                //return the private data
                return mThisCar;
            }
            set
            {
                //set the private data
                mThisCar = value;
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

        
    }
}