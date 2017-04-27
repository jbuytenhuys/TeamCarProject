using MyClassLibrary;
using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();


        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
            }
        }
        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }

        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public clsSupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsSupplier AnSupplier = new clsSupplier();
                AnSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AnSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnSupplier.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                AnSupplier.County = Convert.ToString(DB.DataTable.Rows[Index]["County"]);
                AnSupplier.Mobile = Convert.ToString(DB.DataTable.Rows[Index]["Mobile"]);
                AnSupplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                AnSupplier.PostionInCompany = Convert.ToString(DB.DataTable.Rows[Index]["PostionInCompany"]);
                AnSupplier.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AnSupplier.WorkExt = Convert.ToString(DB.DataTable.Rows[Index]["WorkExt"]);
                AnSupplier.WorkNumber = Convert.ToString(DB.DataTable.Rows[Index]["WorkNumber"]);
                AnSupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                //return that everything worked ok
                mSupplierList.Add(AnSupplier);
                Index++;

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@City", mThisSupplier.City);
            DB.AddParameter("@County", mThisSupplier.County);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@Mobile", mThisSupplier.Mobile);
            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Postcode", mThisSupplier.PostCode);
            DB.AddParameter("@PostionInCompany", mThisSupplier.PostionInCompany);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Title", mThisSupplier.Title);
            DB.AddParameter("@WorkExt", mThisSupplier.WorkExt);
            DB.AddParameter("@WorkNumber", mThisSupplier.WorkNumber);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.Execute("sproc_tblSupplier_DeleteMethodOK");
        }
        public void Update()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@City", mThisSupplier.City);
            DB.AddParameter("@County", mThisSupplier.County);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@Mobile", mThisSupplier.Mobile);
            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Postcode", mThisSupplier.PostCode);
            DB.AddParameter("@PostionInCompany", mThisSupplier.PostionInCompany);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Title", mThisSupplier.Title);
            DB.AddParameter("@WorkExt", mThisSupplier.WorkExt);
            DB.AddParameter("@WorkNumber", mThisSupplier.WorkNumber);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.Execute("sproc_tblSupplier_Update");


        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 Recordcount;
            Recordcount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < Recordcount)
            {
                clsSupplier AnSupplier = new clsSupplier();
                AnSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AnSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnSupplier.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                AnSupplier.County = Convert.ToString(DB.DataTable.Rows[Index]["County"]);
                AnSupplier.Mobile = Convert.ToString(DB.DataTable.Rows[Index]["Mobile"]);
                AnSupplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                AnSupplier.PostionInCompany = Convert.ToString(DB.DataTable.Rows[Index]["PostionInCompany"]);
                AnSupplier.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AnSupplier.WorkExt = Convert.ToString(DB.DataTable.Rows[Index]["WorkExt"]);
                AnSupplier.WorkNumber = Convert.ToString(DB.DataTable.Rows[Index]["WorkNumber"]);
                AnSupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                mSupplierList.Add(AnSupplier);
                Index++;
            }
        }

        public void FilterByPostCode(string PostCode)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PostCode", PostCode);
            DB.Execute("sproc_tblSupplier_FilterByPostCode");
            PopulateArray(DB);
        }


        //WRITTEN BY JACK.
        public void FilterBySupplierEmail(string SupplierEmail)
        {
            //filters the records based on a full or partial car manufacturer.
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the car Manufacturer parameter to the database
            DB.AddParameter("@SupplierEmail", SupplierEmail);
            //Execute stored procedure.
            DB.Execute("sproc_tblSupplier_tblCars_FilterBySupplierEmail");
            //populate array list with table data.
            PopulateArray(DB);
        }



        public void FilterByWorkNumber(string WorkNumber)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@WorkNumber", WorkNumber);
            DB.Execute("sproc_tblSupplier_FilterByWorkNumber");
            PopulateArray(DB);
        }

        public void FilterBySupplierName(string SupplierName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", SupplierName);
            DB.Execute("sproc_tblSupplier_FilterBySupplierName");
            PopulateArray(DB);
        }





    }
}

//dd










