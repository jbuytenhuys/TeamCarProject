using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstcustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.ActiveOK = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerAddress = "20 Austen Avenue";
            TestItem.CustomerEmail = "zadbhatti@hotmail.com";
            TestItem.CustomerFirstName = "zad";
            TestItem.CustomerLastName = "Ali";
            TestItem.CustomerPostCodeOK = "NG7 6PE";
            TestItem.DateAddedOK = DateTime.Now.Date;
            //add the item to the test List
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test objective 
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection Allcustomers = new clsCustomerCollection();
            //create the items of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ActiveOK = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstName = "Zad";
            TestItem.CustomerLastName = "Ali";
            TestItem.CustomerAddress = "20 Austen Avenue";
            TestItem.CustomerPostCodeOK = "Ng7 6PE";
            TestItem.CustomerEmail = "zadbhatti@hotmail.com";
            TestItem.DateAddedOK = DateTime.Now.Date;
            //set ThisCustomer to the test data
            Allcustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = Allcustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            Allcustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(Allcustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "zadbhatti@hotmail.com";
            TestItem.CustomerFirstName = "zad";
            TestItem.CustomerLastName = "ali";
            TestItem.CustomerPostCodeOK = "NG7 6PE";
            TestItem.ActiveOK = true;
            TestItem.DateAddedOK = DateTime.Now.Date;
            //set this repair to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Delete the record
            AllCustomers.Delete();
            //Now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see if the two values are the same
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ActiveOK = true;
            TestItem.CustomerAddress = "20 Austen Avenue";
            TestItem.CustomerEmail = "zadbhatti@hotmail.com";
            TestItem.CustomerFirstName = "zad";
            TestItem.CustomerLastName = "ali";
            TestItem.CustomerPostCodeOK = "NG7 6PE";
            TestItem.DateAddedOK = DateTime.Now.Date;
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.ActiveOK = false;
            TestItem.CustomerAddress = "30 Austen Avenue";
            TestItem.CustomerEmail = "jonaidbhatti@hotmail.com";
            TestItem.CustomerFirstName = "jay";
            TestItem.CustomerLastName = "bhatti";
            TestItem.CustomerPostCodeOK = "LE1 5TH";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see thisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void FilterByCustomerFirstNameOK(string CustomerFirstName)
        {
            //Create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string {(should return all records)
            FilteredCustomers.FilterByCustomerFirstName("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.count, FilteredCustomers.count);
        }

        [TestMethod]
        public void FilterByCustomerFirstNameOKNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //aply a first name that doestn exist
            FilteredCustomers.FilterByCustomerFirstName("Seeya");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.count);
        }
        [TestMethod]
        public void FilterByCustomerFirstNameOKTestDataFound()
        {
            //create instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a First Name that doesnt exist
            FilteredCustomers.FilterByCustomerFirstName("charlie");
            //chek that the correct number of record are found
            if (FilteredCustomers.count ==2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerID != 36)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see there are no records
            Assert.IsTrue(OK);
        }
    }
}
