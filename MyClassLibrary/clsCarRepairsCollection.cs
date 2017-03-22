using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCarRepairsCollection
    {
        //Private data member for the list
        List<clsCarRepairs> mCarRepairList = new List<clsCarRepairs>();
        
        public clsCarRepairsCollection()
        {
            //Variable for the index
            Int32 Index = 0;
            //Variable for the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DataBase = new clsDataConnection();
            //Execute stored procedure
            DataBase.Execute("sproc_tblCarRepairs_SelectAll");
            //get the count of the records
            RecordCount = DataBase.Count;
            //while there are records to rpocess
            while (Index < RecordCount)
            {
                //Create a blank CarRepair
                clsCarRepairs Arepair = new clsCarRepairs();
                //Read in the fields from the current record
                Arepair.CarRepairID = Convert.ToInt32(DataBase.DataTable.Rows[Index]["CarRepairID"]);
                Arepair.DaysInForRepair = Convert.ToInt32(DataBase.DataTable.Rows[Index]["DaysInForRepair"]);
                Arepair.DeadlineDate = Convert.ToDateTime(DataBase.DataTable.Rows[Index]["DeadlineDate"]);
                Arepair.PartPrice = Convert.ToDecimal(DataBase.DataTable.Rows[Index]["PartPrice"]);
                Arepair.PartRequired = Convert.ToString(DataBase.DataTable.Rows[Index]["PartRequired"]);
                Arepair.RepairStatus = Convert.ToBoolean(DataBase.DataTable.Rows[Index]["RepairStatus"]);
                //Add the record to the private data member
                mCarRepairList.Add(Arepair);
                //point at the next record
                Index++;
            }

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
        public clsCarRepairs ThisCarRepair { get; set; }
    }
}