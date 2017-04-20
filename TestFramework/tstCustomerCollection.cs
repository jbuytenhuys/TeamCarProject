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
    }
}
