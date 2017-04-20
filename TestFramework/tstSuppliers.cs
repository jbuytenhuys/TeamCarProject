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
            clsSupplier Supplier = new clsSupplier();
            //this is an instance of clsaddress
            Assert.IsNotNull(Supplier);
        }
        [TestMethod]
        public void DateAddedOK()
        {
            clsSupplier Supplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            Supplier.DateAdded = TestData;
            Assert.AreEqual(Supplier.DateAdded, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "19A";
            Supplier.Address = TestData;
            Supplier.Address = TestData;
            Assert.AreEqual(Supplier.Address, TestData);
        }
        [TestMethod]
        public void CityOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "Birmingham";
            Supplier.City = TestData;
            Supplier.City = TestData;
            Assert.AreEqual(Supplier.City, TestData);
        }
        [TestMethod]
        public void CountyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "WestMidlands";
            Supplier.County = TestData;
            Supplier.County = TestData;
            Assert.AreEqual(Supplier.County, TestData);
        }
        [TestMethod]
        public void PostCodeOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "B69 2HY";
            Supplier.PostCode = TestData;
            Supplier.PostCode = TestData;
            Assert.AreEqual(Supplier.PostCode, TestData);
        }
        [TestMethod]
        public void PostionInCompanyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "Head of sales";
            Supplier.PostionInCompany = TestData;
            Supplier.PostionInCompany = TestData;
            Assert.AreEqual(Supplier.PostionInCompany, TestData);
        }
        [TestMethod]
        public void MobileOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "078";
            Supplier.Mobile = TestData;
            Supplier.Mobile = TestData;
            Assert.AreEqual(Supplier.Mobile, TestData);

        }
        [TestMethod]
        public void WorkNumberOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "01215478965";
            Supplier.WorkNumber = TestData;
            Supplier.WorkNumber = TestData;
            Assert.AreEqual(Supplier.WorkNumber, TestData);

        }
        [TestMethod]
        public void SupplierNameOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "Mark Davis";
            Supplier.SupplierName = TestData;
            Assert.AreEqual(Supplier.SupplierName, TestData);

        }
        [TestMethod]
        public void TitleOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "Mr";
            Supplier.Title = TestData;
            Assert.AreEqual(Supplier.Title, TestData);

        }
        [TestMethod]
        public void SupplierIDOK()
        {
            clsSupplier Supplier = new clsSupplier();
            Int32 TestData = 1;
            Supplier.SupplierID = TestData;

            Assert.AreEqual(Supplier.SupplierID, TestData);

        }
        [TestMethod]
        public void WorkExtOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "359";
            Supplier.WorkExt = TestData;
            Assert.AreEqual(Supplier.WorkExt, TestData);

        }
        [TestMethod]
        public void ActiveSupplierOK()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Test = true;
            Supplier.Active = Test;
            Assert.AreEqual(Supplier.Active, Test);
        }

        [TestMethod]
        public void SupplierFindMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierAddressFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Address != "19A")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierCityFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.City != "Birmingham")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierCountyFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.County != "w")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierMobileFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Mobile != "078")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestNameFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Name != "Gurdip")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.SupplierName != "BMW")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierPostcodeFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.PostCode != "B69 2HY")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestPostionInCompany()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.PostionInCompany != "HeadOfSales")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierTitle()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Title != "Mr")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierWorkExt()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.WorkExt != "313")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierWorkNumber()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.WorkNumber != "121")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSupplierDateAdded()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierID = 1;
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.DateAdded != Convert.ToDateTime("08/03/2017"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }

        [TestMethod]
        public void SupplierAddressMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SupplierAddressMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "BB";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierAddressMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SupplierAddressMidx()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "";
            Address = Address.PadRight(500, 'a');
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void SupplierCityMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SupplierCityMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "B";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void SupplierCityMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "BB";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierCityMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierCityMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierCityMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierCityMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void SupplierCityExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "";
            City = City.PadRight(500, 'a');
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierCountyMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SupplierCountyMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "e";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void SupplierCountyMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "ea";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierCountyMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierCountyMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierCountyMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierCountyMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void SupplierCountyExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "";
            County = County.PadRight(500, 'b');
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void NameMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NameMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "M";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Ma";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void NameMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NameMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void NameExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "";
            Name = Name.PadRight(500, 'c');
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void PostionInCompanyMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PostionInCompanyMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "A";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PostionInCompanyMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Ac";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PostionInCompanyMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PostionInCompanyMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostionInCompanyMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void PostionInCompanyMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void PostionInCompanyExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "";
            PostionInCompany = PostionInCompany.PadRight(500, 'r');
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "A";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Ac";
            string SupplierName = "Au";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb49";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb50";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "1bbbbbbbbbbbbbbbbbbbbbb25";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "1bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb51";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6";
            String PostionInCompany = "Accounts";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'A');
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierPostcodeMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void SupplierPostcodeMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "C";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void SupplierPostcodeMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierPostcodeMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV671GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierPostcodeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "1CV6CVR8";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierPostcodeMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CVC4";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SupplierPostcodeMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV67GX3S9";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierPostcodeExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "";
            Postcode = Postcode.PadRight(500, 'E');
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierTitleMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void SupplierTitlePostcodeMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "M";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }



        [TestMethod]
        public void SupplierTitleMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierTitleMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mis4";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SupplierTitleMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Miss5";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierTitlecodeMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mrr4";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SupplierTitlePlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mrrrrr6";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierTitleExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "";
            Title = Title.PadRight(500, 'E');
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void WorkExtMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void WorkExtMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "1";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkExtMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "12";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void WorkExtMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "1234";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkExtMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "12345";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WorkExtMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "123";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void WorkExtPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "123456";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void WorkExtExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "";
            WorkExt = WorkExt.PadRight(500, 'E');
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void WorkNumberMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void WorkNumberMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "1";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkNumberMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkNumberMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "1000000010";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void WorkNumberMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "10000000011";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WorkNumberMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12345";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void WorkNumberPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "100000000012";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void WorkNumberExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "";
            WorkExt = WorkExt.PadRight(500, '1');
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void MobileMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void MobileMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "1";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void MobileMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "12";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void MobileMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "1000000010";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void MobileMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "10000000011";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void MobileMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "12345";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void MobilePlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "100000000012";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }


        [TestMethod]
        public void MobileExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = DateTime.Now.Date.ToString();
            String Mobile = "";
            Mobile = Mobile.PadRight(500, '2');
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
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
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
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
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
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
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
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
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean OK = false;
            string Address = "1b";
            string City = "Birmingham";
            string County = "eastmidlands";
            string DateAdded = "THIS IS NOT A DATE";
            String Mobile = "078";
            String Name = "Mark";
            string Postcode = "CV6 7GX";
            String PostionInCompany = "Accounts";
            string SupplierName = "Audi";
            string Title = "Mr";
            string WorkExt = "312";
            string WorkNumber = "12134";
            OK = AnSupplier.Valid(Address, City, County, DateAdded, Mobile, Name, Postcode, PostionInCompany, SupplierName, Title, WorkExt, WorkNumber);
            Assert.IsFalse(OK);
        }
    }
}






