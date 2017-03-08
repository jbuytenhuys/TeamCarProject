using System;

namespace MyClassLibrary
{
    public class clsSupplier
    {
        private string mAddress;
        private string mCity;
        private string mCounty;
        private DateTime mDateAdded;
        private string mMoblie;
        private string mName;
        private string mPostcode;
        private string mPostionInCompany;
        private string mSupplierID;
        private string mSupplierName;
        private string mTitle;
        private string mWorkExt;
        private string mWorkNumber;

        public clsSupplier()
        {
        }


        public Boolean Active { get; set; }
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
        public string PostCode
        {
            get
            //return the private data.
            { return mPostcode; }

            set
            //set the value pf the private data member.
            { mPostcode = value; }
        }
        public string PostionInCompany
        {
            get
            //return the private data.
            { return mPostionInCompany; }

            set
            //set the value pf the private data member.
            { mPostionInCompany = value; }
        }
        public String SupplierID
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

        public bool Find(string supplierID)
        {
            mSupplierID = "1";
            mAddress = "r";
            mCity = "b";
            mCounty = "w";
            mMoblie = "078";
            mName = "Gurdip";
            mSupplierName = "BMW";
            mPostcode = "B69";
            mPostionInCompany = "HeadOfSales";
            mTitle = "Mr";
            mWorkExt = "313";
            mWorkNumber = "0121";
            mDateAdded = Convert.ToDateTime("08/03/2017");
            return true;
        }
    }
}
