using System;

namespace MyClassLibrary
{
    public class clsSupplier
    {
        public clsSupplier()
        {
        }


        public Boolean Active { get; set; }

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress; // asks system to returmn data to view
            }
            set
            {
                mAddress = value;// asks system to edit data
            }
        }
        public string City { get; set; }
        public string County { get; set; }
        public DateTime DateAdded { get; set; }
        public long Mobile { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }
        public string PostionInCompany { get; set; }
        public long SupplierID { get; set; }

        private string mSupplierName;
        public string SupplierName
        {
            get
            {
                return mSupplierName;

            }
            set
            {
                mSupplierName = value;
            }
        }
        public long WorkExt { get; set; }

        private string mWorkNumber; //this creates a new varible
        public string WorkNumber
        {
            get
            {
                return mWorkNumber; // asks system to returmn data to view
            }
            set
            {
                mWorkNumber = value;// asks system to edit data
            }
        }

        public bool Find(Int64 SupplierID)
        {
            mWorkNumber = "01215478965";
            return true;
        }

        public bool Find(string supplierName)
        {
            mSupplierName = "Gurdip";
            return true;
        }
    }
}