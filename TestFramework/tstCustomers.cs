using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

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
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Customer.ActiveOK = TestData;
            //test to see that it exists
            Assert.AreEqual(Customer.ActiveOK, TestData);
        }
        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Customer.DateAddedOK = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.DateAddedOK, TestData);
        }

        [TestMethod]
        public void CustomerAddress()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "20 Forest Road";
            Customer.CustomerAddress = TestData;
            //test to see that it exists
            Assert.AreEqual(Customer.CustomerAddress, TestData);
        }
        [TestMethod]
        public void CustomerEmailOK()
        {
            ////create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "smith@dmu.ac.uk";
            Customer.CustomerEmail = TestData;
            //test to see that it exists
            Assert.AreEqual(Customer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void CustomerFirstNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "Zad";
            Customer.CustomerFirstName = TestData;
            //test to see that it exists
            Assert.AreEqual(Customer.CustomerFirstName, TestData);
        }
        [TestMethod]
        public void CustomerPostCodeOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "XXX XXX";
            Customer.CustomerPostCodeOK = TestData;
            //test to see that it exists
            Assert.AreEqual(Customer.CustomerPostCodeOK, TestData);
        }
        [TestMethod]
        public void CustomerLastNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            string TestData = "Paul";
            Customer.CustomerLastName = TestData;
            //test to see that it exists
            Assert.AreEqual(Customer.CustomerLastName, TestData);
        }
        [TestMethod]
        public void CustomerFindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with method
            Int32 CustomerID = 1;
            //test to see that the result is correct
            Found = Customer.Find(CustomerID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //bolean variable to record if data is ok
            Boolean OK = true;
            //create some test data 
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the customer id
            if (Customer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is coorecct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //bolean variable to record if data is ok
            Boolean OK = true;
            //create some test data 
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the customer id
            if (Customer.CustomerAddress != "20 Austen avenue")
            {
                OK = false;
            }
            //test to see that the result is coorecct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //bolean variable to record if data is ok
            Boolean OK = true;
            //create some test data 
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the customer id
            if (Customer.CustomerEmail != "zadbhatti@hotmail.com")
            {
                OK = false;
            }
            //test to see that the result is coorecct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerFrstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //bolean variable to record if data is ok
            Boolean OK = true;
            //create some test data 
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the customer id
            if (Customer.CustomerFirstName != "Zad")
            {
                OK = false;
            }
            //test to see that the result is coorecct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerPostCodeOKFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //bolean variable to record if data is ok
            Boolean OK = true;
            //create some test data 
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the customer id
            if (Customer.CustomerPostCodeOK != "NG7 6PE")
            {
                OK = false;
            }
            //test to see that the result is coorecct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //bolean variable to record if data is ok
            Boolean OK = true;
            //create some test data 
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the customer id
            if (Customer.CustomerLastName != "Ali")
            {
                OK = false;
            }
            //test to see that the result is coorecct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedOKFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //bolean variable to record if data is ok
            Boolean OK = true;
            //create some test data 
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the property
            if (Customer.DateAddedOK != Convert.ToDateTime("08/03/2017"))
            {
                OK = false;
            }
            //test to see that the result is coorecct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveOKFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //bolean variable to record if data is ok
            Boolean OK = true;
            //create some test data 
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the property
            if (Customer.ActiveOK != true)
            {
                OK = false;
            }
            //test to see that the result is coorecct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method 
            string CustomerAddress = "20 Austen Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "2";
            string CustomerEmail = "zadBhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue ";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeeeeeeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedOKExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            //create a variable to store the test data
            DateTime TestDate;
            //set the todays date 
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //comvert the date variable to a string varibale
            string DateAddedOK = TestDate.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedOKMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            //create a variable to store the test data
            DateTime TestDate;
            //set the todays date 
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less than 1 day
            TestDate = TestDate.AddDays(-1);
            //comvert the date variable to a string varibale
            string DateAddedOK = TestDate.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedOKMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            //create a variable to store the test data
            DateTime TestDate;
            //set the todays date 
            TestDate = DateTime.Now.Date;
            //convery the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //comvert the date variable to a string varibale
            string DateAddedOK = TestDate.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            //create a variable to store the test data
            DateTime TestDate;
            //set the todays date 
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //comvert the date variable to a string varibale
            string DateAddedOK = TestDate.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            //create a variable to store the test data
            DateTime TestDate;
            //set the todays date 
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //comvert the date variable to a string varibale
            string DateAddedOK = TestDate.ToString();
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedOKInvalidDate()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PE";
            //set the DateAdded to a non date Value
            string DateAddedOK = "this is not a date!";
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CustomerPostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "";
            string DateAddedOK = "08/03/2017";
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CustomerPostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "N";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEE";//8
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerPostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEE";//9
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = "08/03/2017";
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerPostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenueeeee";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 ";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = "08/03/2017";
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Z";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Za";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zaddddddddddddddddd";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zadddddddddddddddddd";//20
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zadddddddddddddddddda";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zadddddddd";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = "08/03/2017";
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerLastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "A";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Al";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerLastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Aliiiiiiiiiiii";//14
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerLastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Aliiiiiiiiiiiii";//15
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Aliiiiiiiiiiiiia";//16
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerLastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotmail.com";
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Aliiii";//6
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zad@hotmail.co";//max 30 characters min characters 15
            string CustomerFirstName = "";
            string CustomerLastName = "Ali";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = "08/03/2017";
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zad@hotmail.com";//max 30 characters min characters 15
            string CustomerFirstName = "Zad";
            string CustomerLastName = "A";
            string CustomerPostCodeOK = "NG7 6PEEEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zad@hotmail.comm";//max 30 characters min characters 15
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Al";
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhattiiiiiiiiii@hotmail.co";//max 30 characters min characters 15
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Aliiiiiiiiiiii";//14
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhattiiiiiiiiii@hotmail.com";//max 30 characters min characters 15
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Aliiiiiiiiiiiii";//15
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhattiiiiiiiiii@hotmail.comm";//max 30 characters min characters 15
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Aliiiiiiiiiiiiia";//16
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string CustomerAddress = "20 Avenue Avenue";
            string CustomerEmail = "zadbhatti@hotma";//max 30 characters min characters 15
            string CustomerFirstName = "Zad";
            string CustomerLastName = "Aliiii";//6
            string CustomerPostCodeOK = "NG7 6PE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()

        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test objective
            TestCustomer.ActiveOK = true;
            TestCustomer.CustomerAddress = "20 Austen Avenue";
            TestCustomer.CustomerEmail = "Zadbhatti@hotmail.com";
            TestCustomer.CustomerFirstName = "zad";
            TestCustomer.CustomerLastName = "Ali";
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerPostCodeOK = "NG7 6PE";
            TestCustomer.DateAddedOK = DateTime.Now.Date;
            //asign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()

        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ActiveOK = true;
            TestItem.CustomerAddress = "20 Austen Avenue";
            TestItem.CustomerEmail = "zadbhatti@hotmail.com";
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstName = "zad";
            TestItem.CustomerLastName = "Ali";
            TestItem.CustomerPostCodeOK = "NG7 6PE";
            TestItem.DateAddedOK = DateTime.Now.Date;
            //add the data to the test property
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
       

    }
}

