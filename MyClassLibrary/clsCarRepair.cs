using System;

namespace MyClassLibrary
{
    public class clsCarRepair
    {
        private Int32 mCarID;
        private int mDaysInForRepair;
        private DateTime mDeadlineDate;
        private decimal mPartPrice;
        private string mPartRequired;
        private bool mRepairStatus;

        public int CarID
        {
            get
            {
                return mCarID;
            }
            set
            {
                mCarID = value;
            }
        }
        public int DaysInForRepair
        {
            get
            {
                return mDaysInForRepair;
            }
            set
            {
                mDaysInForRepair = value;
            }
        }
        public DateTime DeadlineDate
        {
            get
            {
                return mDeadlineDate;
            }
            set
            {
                mDeadlineDate = value;
            }
        }
        public decimal PartPrice
        {
            get
            {
                return mPartPrice;
            }
            set
            {
                mPartPrice = value;
            }
        }
        public string PartRequired
        {
            get
            {
                return mPartRequired;
            }
            set
            {
                mPartRequired = value;
            }
        }
        public bool RepairStatus
        {
            get
            {
                return mRepairStatus;
            }
            set
            {
                mRepairStatus = value;
            }
        }


        public bool Find(int CarID)
        {
            mCarID = 2;
            mDaysInForRepair = 32;
            mDeadlineDate = Convert.ToDateTime("21/03/2017");
            mPartPrice = 2.2m;
            mPartRequired = "Test Part";
            mRepairStatus = true;
            return true;
        }
    }
}