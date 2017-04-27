using System;

namespace MyClassLibrary
{
    public class clsCarRepairs
    {
        //Private data members for the records in the database
        private int mCarRepairID;
        private int mCarID;
        private int mDaysInForRepair;
        private DateTime mDeadlineDate;
        private decimal mPartPrice;
        private string mPartRequired;
        private bool mRepairStatus;
        private int mStaffID;

        public int CarRepairID //public property for CarRepairID
        {
            get
            {
                //return the private data
                return mCarRepairID;
            }
            set
            {
                //set the private data
                mCarRepairID = value;
            }
        }

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


        public bool Find(int CarRepairID)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CarID to search for 
            DB.AddParameter("@CarRepairID", CarRepairID);
            //execute the stored procedure
            DB.Execute("sproc_tblCarRepairs_FilterByCarID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy data from database to the private data members
                mCarRepairID = Convert.ToInt32(DB.DataTable.Rows[0]["CarRepairID"]);
                //mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mDaysInForRepair = Convert.ToInt32(DB.DataTable.Rows[0]["DaysInForRepair"]);
                mDeadlineDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeadlineDate"]);
                mPartPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["PartPrice"]);
                mPartRequired = Convert.ToString(DB.DataTable.Rows[0]["PartRequired"]);
                mRepairStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["RepairStatus"]);
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                //mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
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
        //Method to validate data input by the euser
        public bool Valid(string DaysInForRepair, string DeadlineDate, string PartPrice, string PartRequired, string CarID)
        {
            //create boolean variable and set it to false
            Boolean OK = true;

            float val;
            if (!float.TryParse((Convert.ToString(CarID)), out val))
            {
                OK = false;
            }
            else
            {
                if (Convert.ToInt32(CarID) == 0)
                {
                    OK = false;
                }

                if (Convert.ToString(CarID).Length < 1)
                {
                    OK = false;
                }
            }

            if (!float.TryParse((Convert.ToString(PartPrice)), out val))
            {
                OK = false;
            }
            else
            {
                if (Convert.ToDecimal(PartPrice) < 1m)
                {
                    OK = false;
                }

                if (Convert.ToDecimal(PartPrice) > 10000m)
                {
                    OK = false;
                }
            }

            if (!float.TryParse((Convert.ToString(DaysInForRepair)), out val))
            {
                OK = false;
            }
            else
            {
                if (Convert.ToInt32(DaysInForRepair) == 0)
                {
                    OK = false;
                }

                if (Convert.ToInt32(DaysInForRepair) > 60)
                {
                    OK = false;
                }
            }

            DateTime DateTemp;
            try
            {
                DateTemp = Convert.ToDateTime(DeadlineDate);
                DateTime TestDate = DateTime.Now.Date;

                if (DateTemp < DateTime.Now.Date)
                {
                    OK = false;
                }

                if (DateTemp > TestDate.AddDays(60))
                {
                    OK = false;
                }
            }

            catch
            {
                OK = false;
            }
            
            if (PartRequired.Length == 0)
            {
                OK = false;
            }

            if (PartRequired.Length >32)
            {
                OK = false;
            }

            return OK;
        }
    }
}