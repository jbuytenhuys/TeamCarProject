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
            Customer.CustomerPostcodeOK = TestData;
            //test to see that it exists
            Assert.AreEqual(Customer.CustomerPostcodeOK, TestData);
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
            Assert.IsTrue(OK);
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
            if (Customer.CustomerPostcodeOK != "NG7 6PE")
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
            Assert.IsFalse(OK);
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
            Assert.IsFalse(OK);

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
            Assert.IsFalse(OK);

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
            Assert.IsFalse(OK);

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
            Assert.IsFalse(OK);
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
            Assert.IsFalse(OK);
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
            Assert.IsFalse(OK);
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
            string CustomerPostCodeOK = "NG7 6PEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
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
            string CustomerPostCodeOK = "NG7 6PEEE";
            string DateAddedOK = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            OK = Customer.valid(CustomerAddress, CustomerEmail, CustomerFirstName, CustomerLastName, CustomerPostCodeOK, DateAddedOK);
            //test to see that the result is correct
            Assert.IsFalse(OK);
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
            Assert.IsFalse(OK);
        }



    }  
}

