using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class clsStaff
    {
        //Private data members for the records in the database
        private int mStaffID;
        private string mStaffFirstName;
        private string mStaffSurname;
        private string mStaffRole;

        public int StaffID //public property for CarRepairID
        {
            get
            {
                //return the private data
                return mStaffID;
            }
            set
            {
                //set the private data
                mStaffID = value;
            }
        }

        public string StaffFirstName //public property for PartRequired
        {
            get
            {
                //return the private data
                return mStaffFirstName;
            }
            set
            {
                //set the private data
                mStaffFirstName = value;
            }
        }
        public string StaffSurname //public property for RepairStatus
        {
            get
            {
                //return the private data
                return mStaffSurname;
            }
            set
            {
                //set the private data
                mStaffSurname = value;
            }
        }

        public string StaffRole //public property for StaffID
        {
            get
            {
                //return the private data
                return mStaffRole;
            }
            set
            {
                //set the private data
                mStaffRole = value;
            }
        }


        public bool Find(int StaffID)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CarID to search for 
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy data from database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffSurname = Convert.ToString(DB.DataTable.Rows[0]["StaffSurname"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}
