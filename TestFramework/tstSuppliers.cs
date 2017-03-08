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
            String TestData = "12345678";
            Supplier.SupplierID = TestData;
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
        public void FindMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            string SupplierID = "1";
            Found = AnSupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierAddressFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            string SupplierID = "1";
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.Address != "r")
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
            string SupplierID = "1";
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.City != "b")
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
            string SupplierID = "1";
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
            string SupplierID = "1";
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
            string SupplierID = "1";
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
            string SupplierID = "1";
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
            string SupplierID = "1";
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.PostCode != "B69")
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
            string SupplierID = "1";
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
            string SupplierID = "1";
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
            string SupplierID = "1";
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
            string SupplierID = "1";
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.WorkNumber != "0121")
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
            string SupplierID = "1";
            Found = AnSupplier.Find(SupplierID);
            if (AnSupplier.DateAdded != Convert.ToDateTime("08/03/2017"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);


        }

    }
}






