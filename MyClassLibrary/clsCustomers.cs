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



        public bool Find(int CustomerID)
        {
            //create an instance of the DB connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilterByCustomerNo");
            //if one record is found
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mActiveOK = Convert.ToBoolean(DB.DataTable.Rows[0]["ActiveOK"]);
                mDateAddedOK = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAddedOK"]);
                mCustomerPostCodeOK = Convert.ToString(DB.DataTable.Rows[0]["CustomerPostCodeOK"]);
                //return everything that worked ok
                return true;
            }
            else
            {
                //return false indicaing a problem
                return false;
            }
        }

        public bool valid(string CustomerAddress, string CustomerEmail, string CustomerFirstName, string CustomerLastName, string CustomerPostCodeOK, string DateAddedOK)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store the data value
            DateTime DateTemp;
            //if the CustomerAddres is is blank 

            if (CustomerAddress.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the CustomerAdress is greater than 20 characters
            if (CustomerAddress.Length > 20)
            {
                //set the flag OK to false
                OK = false;
            }
            //try to date validation assuming the data is a valid date 
            try
            {
                //copy the DateAddeDOK value to the DateTemp Variable 
                DateTemp = Convert.ToDateTime(DateAddedOK);
                    //check to see if the date is less than todays date
                    if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }

                //check to see if the date is greater then todays time 
                if
                    (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
                //the data was not a date so flag an error
                catch
            {
                //set the flag ok to false
                OK = false;
            }
            
            //is the postcode blank 
            if (CustomerPostCodeOK.Length ==0)
            {
                //set the flag ok to false 
                OK = false;
            }

            //if the postcode is too long
            if (CustomerPostCodeOK.Length > 9)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the firsname is blank 
            if (CustomerFirstName.Length ==0)
            {
                //set ok flag to false
                OK = false;
            }

            //if the name is too long
            if (CustomerFirstName.Length > 20)
            {
                //set the flag to falsew
                OK = false;
            }
            //return the value of OK
            return OK;
        }
        
    }
}