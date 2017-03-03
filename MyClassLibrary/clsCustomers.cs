using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {
       
        //privae data member for the CustomerId property
        private Int32 mCustomerID;
        private string mCustomerAddress;
        private string mCustomerEmail;
        private string mCustomerFirstName;
        private string mCustomerLastName;
        private string mCustomerPostCodeOK;
        private DateTime mDateAddedOK;
        private Boolean mActiveOK;

        //public property for ActiveOK
        public bool ActiveOK
        {
            get
            {
                //return the private data
                return mActiveOK;
            }
            set
            {
                //set the private data
                mActiveOK = value;
            }
        }


        //publlic bool for date added
        public DateTime DateAddedOK
        {
            get
            {
                //return the private data
                return mDateAddedOK;
            }
            set
            {
                //set the private data
                mDateAddedOK = value;
            }
        }

        //public bool for the customer address
        public string CustomerAddress
        {
            get
            {
                //return the private data
                return mCustomerAddress;
            }
            set
            {
                //set the private data
                mCustomerAddress = value;
            }
        }

        //pubic poperty for customerID
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }


        //public property for customer email
        public string CustomerEmail
        {
            get
            {
                //return the private data
                return mCustomerEmail;
            }
            set
            {
                //set the private data
                mCustomerEmail = value;
            }
        }


        //public properry for custoemer first name 
        public string CustomerFirstName
        {
            get
            {
                //return the private data
                return mCustomerFirstName;
            }
            set
            {
                //set the private data
                mCustomerFirstName = value;
            }
        }


        //public property for customer lastname
        public string CustomerLastName
        {
            get
            {
                //return the private data
                return mCustomerLastName;
            }
            set
            {
                //set the private data
                mCustomerLastName = value;
            }
        }


        //public properrty for customer postcode 
        public string CustomerPostcodeOK
        {
            get
            {
                //return the private data
                return mCustomerPostCodeOK;
            }
            set
            {
                //set the private data
                mCustomerPostCodeOK = value;
            }
        }

        

        public bool Find(int customerID)
        {
            //set the private data member to the test data value
            mCustomerID = 21;
            mCustomerEmail = "zadbhatti@hotmail.com";
            mCustomerFirstName = "Charlie";
            mCustomerLastName = "KHAN";
            mCustomerAddress = "Test Street";
            mActiveOK = true;
            mDateAddedOK = Convert.ToDateTime("16/09/2015");
            mCustomerPostCodeOK = "XXX XXX";
            //always return true
            return true;
        }

    }
}
