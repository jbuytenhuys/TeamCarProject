using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThiscustomer = new clsCustomer();
        public int count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
            }
        }
        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return he count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThiscustomer;
            }
            set
            {
                //set the private data
                mThiscustomer = value;
            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //objects for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procdue 
            DB.Execute("sproc_tblCustomers_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer Customer = new clsCustomer();
                //read in the fields from the current mood
                Customer.ActiveOK = Convert.ToBoolean(DB.DataTable.Rows[Index]["ActiveOK"]);
                Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Customer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                Customer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                Customer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                Customer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                Customer.CustomerPostCodeOK = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPostCodeOK"]);
                Customer.DateAddedOK = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAddedOK"]);
                //add the record to the private data member
                mCustomerList.Add(Customer);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@CustomerAddress", mThiscustomer.CustomerAddress);
            DB.AddParameter("@CustomerEmail", mThiscustomer.CustomerEmail);
            DB.AddParameter("@CustomerfirstName", mThiscustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThiscustomer.CustomerLastName);
            DB.AddParameter("@CustomerPostCodeOK", mThiscustomer.CustomerPostCodeOK);
            DB.AddParameter("@DateAddedOK", mThiscustomer.DateAddedOK);
            DB.AddParameter("@ActiveOK", mThiscustomer.ActiveOK);
            //execute the qquery returning the primary key value
            return DB.Execute("sproc_tblCustomers_Insert");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }

}
          
            


