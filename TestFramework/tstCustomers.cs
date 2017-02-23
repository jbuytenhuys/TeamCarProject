using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(Customer);
        }
        [TestMethod]
        public void ActiveOK()
        {
            //create an instance of the class we want to create zaddy
            clsCustomer Customer = new clsCustomer();
            Boolean TestData = true;
            Customer.Active = TestData;
            //test to see that it exists
            Assert.AreEqual(Customer.Active, TestData);
        }
        [TestMethod]
        public void CustomerAddress()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "20 Forest Road";
            Customer.CustomerAddress = TestData;
            Assert.AreEqual(Customer.CustomerAddress, TestData);
        }
        [TestMethod]
        public void CustomerEmailOK()
        {
            ////create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "smith@dmu.ac.uk";
            Customer.CustomerEmail = TestData;
            Assert.AreEqual(Customer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void CustomerFirstNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "smith";
            Customer.CustomerFirstName = TestData;
            Assert.AreEqual(Customer.CustomerFirstName, TestData);
        }
        [TestMethod]
        public void CustomerPostCodeOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "LE1 5TH";
            Customer.CustomerPostCode = TestData;
            Assert.AreEqual(Customer.CustomerPostCode, TestData);
        }
        [TestMethod]
        public void CustomerLastNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "Paul";
            Customer.CustomerLastName = TestData;
            Assert.AreEqual(Customer.CustomerLastName, TestData);
        }
        [TestMethod]
        public void FindCustomerIDOK()
        {
            //create an instance of the class we want to create zad
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = Customer.Find(CustomerID);
            Assert.IsTrue(Found);
        }


    }


}
