﻿using System;

namespace MyClassLibrary
{
    public class clsSupplier
    {
        //Private data members for the records in the database
        private string mAddress;
        private string mCity;
        private string mCounty;
        private DateTime mDateAdded;
        private string mMoblie;
        private string mName;
        private string mPostcode;
        private string mPositionInCompany;
        private Int32 mSupplierID;
        private string mSupplierName;
        private string mTitle;
        private string mWorkExt;
        private string mWorkNumber;
        private string mSupplierEmail;

        public clsSupplier()
        {
        }


        public Boolean Active { get; set; }

        public string SupplierEmail
        {
            get
            //return the private data.
            { return mSupplierEmail; }

            set
            //set the value pf the private data member.
            { mSupplierEmail = value; }
        }
        public string Address
        {
            get
            //return the private data.
            { return mAddress; }

            set
            //set the value pf the private data member.
            { mAddress = value; }
        }
        public string City
        {
            get
            //return the private data.
            { return mCity; }

            set
            //set the value pf the private data member.
            { mCity = value; }
        }
        public string County
        {
            get
            //return the private data.
            { return mCounty; }

            set
            //set the value pf the private data member.
            { mCounty = value; }
        }
        public DateTime DateAdded
        {
            get
            //return the private data.
            { return mDateAdded; }

            set
            //set the value pf the private data member.
            { mDateAdded = value; }
        }

        public string Mobile
        {
            get
            //return the private data.
            { return mMoblie; }

            set
            //set the value pf the private data member.
            { mMoblie = value; }
        }
        public string Name
        {
            get
            //return the private data.
            { return mName; }

            set
            //set the value pf the private data member.
            { mName = value; }
        }
        public string Postcode
        {
            get
            //return the private data.
            { return mPostcode; }

            set
            //set the value pf the private data member.
            { mPostcode = value; }
        }
        public string PositionInCompany
        {
            get
            //return the private data.
            { return mPositionInCompany; }

            set
            //set the value pf the private data member.
            { mPositionInCompany = value; }
        }
        public Int32 SupplierID
        {
            get
            //return the private data.
            { return mSupplierID; }

            set
            //set the value pf the private data member.
            { mSupplierID = value; }
        }
        public string SupplierName
        {
            get
            //return the private data.
            { return mSupplierName; }

            set
            //set the value pf the private data member.
            { mSupplierName = value; }
        }

        public string Title
        {
            get
            //return the private data.
            { return mTitle; }

            set
            //set the value pf the private data member.
            { mTitle = value; }
        }


        public string WorkExt
        {
            get
            //return the private data.
            { return mWorkExt; }

            set
            //set the value pf the private data member.
            { mWorkExt = value; }
        }

        public string WorkNumber
        {
            get
            //return the private data.
            { return mWorkNumber; }

            set
            //set the value pf the private data member.
            { mWorkNumber = value; }
        }

        public bool Find(Int32 SupplierID)
        {

            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@SupplierID", SupplierID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mCounty = Convert.ToString(DB.DataTable.Rows[0]["County"]);
                mMoblie = Convert.ToString(DB.DataTable.Rows[0]["Mobile"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mPositionInCompany = Convert.ToString(DB.DataTable.Rows[0]["PositionInCompany"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mWorkExt = Convert.ToString(DB.DataTable.Rows[0]["WorkExt"]);
                mWorkNumber = Convert.ToString(DB.DataTable.Rows[0]["WorkNumber"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);

                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                // return false
                return false;
            }
        }



        public bool Valid(string Address, string City, string County, string DateAdded, string Mobile, string Name, string Postcode, string PositionInCompany, string SupplierName, string Title, string WorkExt, string WorkNumber, string SupplierEmail)
        {
            Boolean OK = true;

            DateTime DateTemp;

            if (Address.Length == 0)
            {
                OK = false;
            }
            if (Address.Length > 50)
            {
                OK = false;
            }
            if (City.Length == 0)
            {
                OK = false;
            }
            if (City.Length > 50)
            {
                OK = false;
            }
            if (County.Length == 0)
            {
                OK = false;
            }
            if (County.Length > 50)
            {
                OK = false;
            }
            if (Name.Length == 0)
            {
                OK = false;
            }
            if (Name.Length > 50)
            {
                OK = false;
            }
            if (PositionInCompany.Length == 0)
            {
                OK = false;
            }
            if (PositionInCompany.Length > 50)
            {
                OK = false;
            }
            if (SupplierName.Length == 0)
            {
                OK = false;
            }
            if (SupplierName.Length > 50)
            {
                OK = false;
            }
            if (Postcode.Length == 0)
            {
                OK = false;
            }
            if (Postcode.Length > 8)
            {
                OK = false;
            }
            if (Title.Length == 0)
            {
                OK = false;
            }
            if (Title.Length > 5)
            {
                OK = false;
            }
            if (WorkExt.Length == 0)
            {
                OK = false;
            }
            if (WorkExt.Length > 5)
            {
                OK = false;
            }
            if (WorkNumber.Length == 0)
            {
                OK = false;
            }
            if (WorkNumber.Length > 11)
            {
                OK = false;
            }
            if (Mobile.Length == 0)
            {
                OK = false;
            }
            if (Mobile.Length > 11)
            {
                OK = false;
            }
            if (SupplierEmail.Length == 0)
            {
                OK = false;
            }
            if (SupplierEmail.Length > 50)
            {
                OK = false;
            }
            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    OK = false;
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    OK = false;
                }
            }
            catch
            {
                OK = false;
            }
            return OK;
        }

    }
}





