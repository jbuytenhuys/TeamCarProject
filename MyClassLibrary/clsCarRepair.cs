using System;

namespace MyClassLibrary
{
    public class clsCarRepair
    {
        //Private data members for the records in the database
        private int mCarID;
        private int mDaysInForRepair;
        private DateTime mDeadlineDate;
        private decimal mPartPrice;
        private string mPartRequired;
        private bool mRepairStatus;
        private int mStaffID;

        public int CarID //public property for CarID
        {
            get
            {
                //return the private data
                return mCarID;
            }
            set
            {
                //set the private data
                mCarID = value;
            }
        }
        public int DaysInForRepair //public property for DaysInForRepair
        {
            get
            {
                //return the private data
                return mDaysInForRepair;
            }
            set
            {
                //set the private data
                mDaysInForRepair = value;
            }
        }
        public DateTime DeadlineDate //public property for DeadlineDate
        {
            get
            {
                //return the private data
                return mDeadlineDate;
            }
            set
            {
                //set the private data
                mDeadlineDate = value;
            }
        }
        public decimal PartPrice //public property for PartPrice
        {
            get
            {
                //return the private data
                return mPartPrice;
            }
            set
            {
                //set the private data
                mPartPrice = value;
            }
        }
        public string PartRequired //public property for PartRequired
        {
            get
            {
                //return the private data
                return mPartRequired;
            }
            set
            {
                //set the private data
                mPartRequired = value;
            }
        }
        public bool RepairStatus //public property for RepairStatus
        {
            get
            {
                //return the private data
                return mRepairStatus;
            }
            set
            {
                //set the private data
                mRepairStatus = value;
            }
        }

        public int StaffID //public property for StaffID
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


        public bool Find(int CarID)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CarID to search for 
            DB.AddParameter("@CarID", CarID);
            //execute the stored procedure
            DB.Execute("sproc_tblCarRepairs_FilterByCarID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy data from database to the private data members
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mDaysInForRepair = Convert.ToInt32(DB.DataTable.Rows[0]["DaysInForRepair"]);
                mDeadlineDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeadlineDate"]);
                mPartPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["PartPrice"]);
                mPartRequired = Convert.ToString(DB.DataTable.Rows[0]["PartRequired"]);
                mRepairStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["RepairStatus"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
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

        public bool Valid(int DaysInForRepair, string DeadlineDate, decimal PartPrice, string PartRequired)
        {
            Boolean OK = true;
            DateTime DateTemp;

            if (DaysInForRepair == 0)
            {
                OK = false;
            }

            if (DaysInForRepair > 60)
            {
                OK = false;
            }

            DateTemp = Convert.ToDateTime(DeadlineDate);

            if (DateTemp < DateTime.Now.Date)
            {
                OK = false;
            }

            return OK;
        }
    }
}