using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsStaffCollection
    {
        //Private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for ThisCarRepair
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate array list with database
            PopulateArray(DB);
        }

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //worry about this later
                ;
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public void FilterByStaffFirstName(string StaffFirstName)
        {
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the PartRequired parameter to the database
            DB.AddParameter("@StaffFirstName", StaffFirstName);
            //execute stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffFirstName");
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
            mStaffList = new List<clsStaff>();
            //while there are records to rpocess
            while (Index < RecordCount)
            {
                //Create a blank CarRepair
                clsStaff Staff = new clsStaff();
                //Read in the fields from the current record
                Staff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                Staff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                Staff.StaffSurname = Convert.ToString(DB.DataTable.Rows[Index]["StaffSurname"]);
                Staff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                //Add the record to the private data member
                mStaffList.Add(Staff);
                //point at the next record
                Index++;
            }
        }
    }
}