using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class Supplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want to create
            clsSupplier Supplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(Supplier);
        }
        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Supplier.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.DateAdded, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "19A";
            //assign the data to the property
            Supplier.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.Address, TestData);
        }
        [TestMethod]
        public void CityOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Birmingham";
            //assign the data to the property
            Supplier.City = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.City, TestData);
        }
        [TestMethod]
        public void CountyOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "WestMidlands";
            //assign the data to the property
            Supplier.County = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.County, TestData);
        }
        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "B69 2HY";
            //assign the data to the property
            Supplier.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.Postcode, TestData);
        }
        [TestMethod]
        public void PositionInCompanyOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Head of sales";
            //assign the data to the property
            Supplier.PositionInCompany = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.PositionInCompany, TestData);
        }
        [TestMethod]
        public void MobileOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "078";
            //assign the data to the property
            Supplier.Mobile = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.Mobile, TestData);

        }
        [TestMethod]
        public void WorkNumberOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "01215478965";
            //assign the data to the property
            Supplier.WorkNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.WorkNumber, TestData);

        }
        [TestMethod]
        public void SupplierNameOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Mark Davis";
            //assign the data to the property
            Supplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.SupplierName, TestData);

        }
        [TestMethod]
        public void TitleOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Mr";
            //assign the data to the property
            Supplier.Title = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.Title, TestData);

        }
        [TestMethod]
        public void SupplierIDOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Supplier.SupplierID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.SupplierID, TestData);

        }
        [TestMethod]
        public void WorkExtOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "359";
            //assign the data to the property
            Supplier.WorkExt = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.WorkExt, TestData);

        }
        [TestMethod]
        public void ActiveSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean Test = true;
            //assign the data to the property
            Supplier.Active = Test;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.Active, Test);
        }

        [TestMethod]
        public void SupplierFindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with method
            Int32 SupplierID = 30;
            //test to see that the result is correct
            Found = AnSupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierAddressFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            //invoke the method
            Found = AnSupplier.Find(SupplierID);
            //check the customer id
            if (AnSupplier.Address != "1b")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierCityFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            //invoke the method
            Found = AnSupplier.Find(SupplierID);
            //check the customer id
            if (AnSupplier.City != "Birmingham")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierCountyFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            //check the customer id
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.County != "eastmidlands")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierMobileFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            //check the customer id
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Mobile != "078")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            //check the customer id
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Name != "Mark")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.SupplierName != "Audi")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierPostcodeFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Postcode != "CV6")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestPositionInCompany()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.PositionInCompany != "1bbbbbbbbbbbbbbbbbbbbbb25")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierTitle()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Title != "Mr")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierWorkExt()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.WorkExt != "312")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierWorkNumber()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.WorkNumber != "12134")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierDateAdded()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data 
            Int32 SupplierID = 30;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.DateAdded != Convert.ToDateTime("29/04/2017"))
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }

        [TestMethod]
        public void SupplierAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SupplierAddressMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "BB";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierAddressMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SupplierAddressMidx()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "";
            Address = Address.PadRight(500, 'a');
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void SupplierCityMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SupplierCityMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "B";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void SupplierCityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "BB";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierCityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierCityMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string SupplierEmail = "Test@Test.com";
            string WorkNumber = "12134";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierCityMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierCityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void SupplierCityExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "";
            City = City.PadRight(500, 'a');
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierCountyMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SupplierCountyMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "e";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void SupplierCountyMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "ea";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierCountyMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierCountyMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierCountyMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierCountyMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void SupplierCountyExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "";
            County = County.PadRight(500, 'b');
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "M";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Ma";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "";
            Name = Name.PadRight(500, 'c');
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void PositionInCompanyMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PositionInCompanyMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "A";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PositionInCompanyMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Ac";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PositionInCompanyMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PositionInCompanyMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PositionInCompanyMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void PositionInCompanyMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void PositionInCompanyExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "";
            PositionInCompany = PositionInCompany.PadRight(500, 'r');
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "A";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Ac";
            string SupplierName = "Au";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PositionInCompany = "Accounts";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'A');
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierPostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void SupplierPostcodeMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "C";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void SupplierPostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierPostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV671GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierPostcodeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "1CV6CVR8";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierPostcodeMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CVC4";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SupplierPostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV67GX3S9";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierPostcodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "";
            Postcode = Postcode.PadRight(500, 'E');
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierTitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void SupplierTitlePostcodeMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "M";
            string WorkExt = "312";
            string SupplierEmail = "Test@Test.com";
            string WorkNumber = "12134";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }



        [TestMethod]
        public void SupplierTitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierTitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mis4";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierTitleMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Miss5";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierTitlecodeMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mrr4";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SupplierTitlePlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mrrrrr6";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierTitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "";
            Title = Title.PadRight(500, 'E');
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void WorkExtMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void WorkExtMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "1";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkExtMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "12";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void WorkExtMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "1234";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkExtMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "12345";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WorkExtMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "123";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void WorkExtPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "123456";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void WorkExtExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "";
            WorkExt = WorkExt.PadRight(500, 'E');
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void WorkNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string SupplierEmail = "Test@Test.com";
            string WorkNumber = "";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void WorkNumberMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "1";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "1000000010";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkNumberMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "10000000011";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WorkNumberMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12345";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void WorkNumberPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "100000000012";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void WorkNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "";
            WorkExt = WorkExt.PadRight(500, '1');
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void MobileMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void MobileMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "1";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";  
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void MobileMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "12";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void MobileMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "1000000010";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void MobileMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "10000000011";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void MobileMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "12345";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void MobilePlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "100000000012";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }


        [TestMethod]
        public void MobileExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "";
            Mobile = Mobile.PadRight(500, '2');
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateAdded = TestDate.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = "THIS IS NOT A DATE";
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PositionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            string SupplierEmail = "Test@Test.com";
            //invoke the method
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PositionInCompany, SupplierName, Title, WorkExt, WorkNumber, SupplierEmail);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}