using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCarRepairsCollection
    {
        //Private data member for the list
        List<clsCarRepairs> mCarRepairList = new List<clsCarRepairs>();
        //private data member for ThisCarRepair
        clsCarRepairs mThisCarRepair = new clsCarRepairs();
        
        public clsCarRepairsCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute stored procedure
            DB.Execute("sproc_tblCarRepairs_SelectAll");
            //populate array list with database
            PopulateArray(DB);
        }

        public List<clsCarRepairs> CarRepairList
        {
            get
            {
                //return the private data
                return mCarRepairList;
            }
            set
            {
                //set the private data
                mCarRepairList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCarRepairList.Count;
            }
            set
            {
                //worry about this later
                ;
            }
        }
        public clsCarRepairs ThisCarRepair
        {
            get
            {
                //return the private data
                return mThisCarRepair;
            }
            set
            {
                //set the private data
                mThisCarRepair = value;
            }
        }

        //add method adds a new record to the database
        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@DaysInForRepair", mThisCarRepair.DaysInForRepair);
            DB.AddParameter("@DeadlineDate", mThisCarRepair.DeadlineDate);
            DB.AddParameter("@PartPrice", mThisCarRepair.PartPrice);
            DB.AddParameter("@PartRequired", mThisCarRepair.PartRequired);
            DB.AddParameter("@RepairStatus", mThisCarRepair.RepairStatus);
            DB.AddParameter("@CarID", mThisCarRepair.CarID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCarRepairs_Insert");
        }

        //Deletes the record pointed to by ThisCarRepair
        public void Delete()
        {
            //connect to data base
            clsDataConnection DB = new clsDataConnection();
            //set parameter for stored procedure
            DB.AddParameter("@CarRepairID", mThisCarRepair.CarRepairID);
            //execute the stored procedure
            DB.Execute("sproc_tblCarRepairs_Archive");
        }

        //Updates existing record in the database
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarRepairID", mThisCarRepair.CarRepairID);
            DB.AddParameter("@DaysInForRepair", mThisCarRepair.DaysInForRepair);
            DB.AddParameter("@DeadlineDate", mThisCarRepair.DeadlineDate);
            DB.AddParameter("@PartPrice", mThisCarRepair.PartPrice);
            DB.AddParameter("@PartRequired", mThisCarRepair.PartRequired);
            DB.AddParameter("@RepairStatus", mThisCarRepair.RepairStatus);
            //execute stored procedure
            DB.Execute("sproc_tblCarRepairs_Update");
        }

        public void FilterByPartRequired(string PartRequired)
        {
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the PartRequired parameter to the database
            DB.AddParameter("@PartRequired", PartRequired);
            //execute stored procedure
            DB.Execute("sproc_tblCarRepairs_FilterByPartRequired");
            //populate array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //Variable for the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCarRepairList = new List<clsCarRepairs>();
            //while there are records to rpocess
            while (Index < RecordCount)
            {
                //Create a blank CarRepair
                clsCarRepairs Arepair = new clsCarRepairs();
                //Read in the fields from the current record
                Arepair.CarRepairID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarRepairID"]);
                Arepair.DaysInForRepair = Convert.ToInt32(DB.DataTable.Rows[Index]["DaysInForRepair"]);
                Arepair.DeadlineDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeadlineDate"]);
                Arepair.PartPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["PartPrice"]);
                Arepair.PartRequired = Convert.ToString(DB.DataTable.Rows[Index]["PartRequired"]);
                Arepair.RepairStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["RepairStatus"]);
                Arepair.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                //Add the record to the private data member
                mCarRepairList.Add(Arepair);
                //point at the next record
                Index++;
            }
        }
    }
}