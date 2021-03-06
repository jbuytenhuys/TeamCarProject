﻿using System;
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
                //return the private data count
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
                //return the count of the list
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
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomers_SelectAll");
            //populate the array list with the dsata table
            PopulateArray(DB);

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
            DB.AddParameter("@CustomerNumber", mThiscustomer.CustomerNumber);
            //execute the qquery returning the primary key value
            return DB.Execute("sproc_tblCustomers_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thiscustomer
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters fpr the stored procedure
            DB.AddParameter("@CustomerID", mThiscustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomersArchived_Archive");
        }

        public void Update()
        {
            //update an existing record based on the vlaues of thisCustomer
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sored procedure
            DB.AddParameter("@CustomerID", mThiscustomer.CustomerID);
            DB.AddParameter("@CustomerAddress", mThiscustomer.CustomerAddress);
            DB.AddParameter("@CustomerEmail", mThiscustomer.CustomerEmail);
            DB.AddParameter("@CustomerfirstName", mThiscustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThiscustomer.CustomerLastName);
            DB.AddParameter("@CustomerPostCodeOK", mThiscustomer.CustomerPostCodeOK);
            DB.AddParameter("@DateAddedOK", mThiscustomer.DateAddedOK);
            DB.AddParameter("@ActiveOK", mThiscustomer.ActiveOK);
            DB.AddParameter("@CustomerNumber", mThiscustomer.CustomerNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_Update");
        }

        public void FilterByCustomerFirstName(string CustomerFirstName)
        {
            //filters the record based on full or partial FisrtName
            //clsDataConnection to the database
            clsDataConnection DB = new clsDataConnection();
            //sent the first name parameter to the database
            DB.AddParameter("@CustomerFirstName", CustomerFirstName);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomers_FilterByFirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void FilterByCustomerAddress(string CustomerAddress)
        {
            //filters the record based on full or partial FisrtName
            //clsDataConnection to the database
            clsDataConnection DB = new clsDataConnection();
            //sent the first name parameter to the database
            DB.AddParameter("@CustomerAddress", CustomerAddress);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomers_FilterByCustomerAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paramter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank customer
                clsCustomer Customer = new clsCustomer();
                //read in the fields from the current record
                Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Customer.ActiveOK = Convert.ToBoolean(DB.DataTable.Rows[Index]["ActiveOK"]);
                Customer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                Customer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                Customer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                Customer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                Customer.CustomerPostCodeOK = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPostCodeOK"]);
                Customer.DateAddedOK = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAddedOK"]);
                Customer.CustomerNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerNumber"]);
                //add the record to the private data mamber
                mCustomerList.Add(Customer);
                //point at the next record
                Index++;

            }
        }

    }
}
          
            


