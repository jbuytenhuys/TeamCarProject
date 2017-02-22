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
            Int64 TestData = 07854698712;
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
            Supplier.SupplierName = TestData;
            Assert.AreEqual(Supplier.SupplierName, TestData);

        }
        [TestMethod]
        public void TitleOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "Mr";
            Supplier.SupplierName = TestData;
            Supplier.SupplierName = TestData;
            Assert.AreEqual(Supplier.SupplierName, TestData);

        }
        [TestMethod]
        public void SupplierIDOK()
        {
            clsSupplier Supplier = new clsSupplier();
            Int64 TestData = 12345678;
            Supplier.SupplierID = TestData;
            Supplier.SupplierID = TestData;
            Assert.AreEqual(Supplier.SupplierID, TestData);

        }
        [TestMethod]
        public void WorkExtOK()
        {
            clsSupplier Supplier = new clsSupplier();
            Int64 TestData = 359;
            Supplier.WorkExt = TestData;
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
        public void FindSupplierID()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int64 SupplierID = 1;
            Found = Supplier.Find(SupplierID);
            if (Supplier.WorkNumber != "01215478965")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindSupplierName()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            string SupplierName = "Gurdip";
            Found = Supplier.Find(SupplierName);
            if (Supplier.SupplierName != "Gurdip")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindSupplierAddress()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            string Address = "19 Redwood Drive";
            Found = Supplier.Find(Address);
            if (Supplier.Address != "19 Redwood Drive")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
    }
   
    
}



