﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
