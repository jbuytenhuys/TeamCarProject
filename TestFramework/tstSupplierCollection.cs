using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //this is an instance of clsaddress
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.Address = "1b";
            TestItem.City = "Birmingham";
            TestItem.County = "eastmidlands";
            TestItem.DateAdded = System.DateTime.Now.Date;
            TestItem.Mobile = "078";
            TestItem.Name = "Mark";
            TestItem.PostCode = "CV6";
            TestItem.PostionInCompany = "1bbbbbbbbbbbbbbbbbbbbbb25";
            TestItem.SupplierName = "Audi";
            TestItem.Title = "Mr";
            TestItem.WorkExt = "312";
            TestItem.WorkNumber = "12134";
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Int32 SomeCount = 0;
            AllSupplier.Count = SomeCount;
            Assert.AreEqual(AllSupplier.Count, SomeCount);
        }
        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.Address = "1b";
            TestSupplier.City = "Birmingham";
            TestSupplier.County = "eastmidlands";
            TestSupplier.DateAdded = System.DateTime.Now.Date;
            TestSupplier.Mobile = "078";
            TestSupplier.Name = "Mark";
            TestSupplier.PostCode = "CV6";
            TestSupplier.PostionInCompany = "1bbbbbbbbbbbbbbbbbbbbbb25";
            TestSupplier.SupplierName = "Audi";
            TestSupplier.Title = "Mr";
            TestSupplier.WorkExt = "312";
            TestSupplier.WorkNumber = "12134";
            AllSupplier.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.Address = "1b";
            TestItem.City = "Birmingham";
            TestItem.County = "eastmidlands";
            TestItem.DateAdded = System.DateTime.Now.Date;
            TestItem.Mobile = "078";
            TestItem.Name = "Mark";
            TestItem.PostCode = "CV6";
            TestItem.PostionInCompany = "1bbbbbbbbbbbbbbbbbbbbbb25";
            TestItem.SupplierName = "Audi";
            TestItem.Title = "Mr";
            TestItem.WorkExt = "312";
            TestItem.WorkNumber = "12134";
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.AreEqual(AllSupplier.Count, 2);
        }
        public void clsSupplierCollection()
        {
            clsSupplier TestItem = new clsSupplier();
            TestItem.Address = "1b";
            TestItem.City = "Birmingham";
            TestItem.County = "eastmidlands";
            TestItem.DateAdded = System.DateTime.Now.Date;
            TestItem.Mobile = "078";
            TestItem.Name = "Mark";
            TestItem.PostCode = "CV6";
            TestItem.PostionInCompany = "1bbbbbbbbbbbbbbbbbbbbbb25";
            TestItem.SupplierName = "Audi";
            TestItem.Title = "Mr";
            TestItem.WorkExt = "312";
            TestItem.WorkNumber = "12134";
            mSupplierList.Add(TestItem);
            TestItem = new clsSupplier();
            TestItem.Address = "2b";
            TestItem.City = "Coventry";
            TestItem.County = "Westmidlands";
            TestItem.DateAdded = System.DateTime.Now.Date;
            TestItem.Mobile = "012";
            TestItem.Name = "Smith";
            TestItem.PostCode = "Cv8";
            TestItem.PostionInCompany = "1ccbbbbbbbbbbbbbbbbbbbb25";
            TestItem.SupplierName = "BMW";
            TestItem.Title = "Mrs";
            TestItem.WorkExt = "222";
            TestItem.WorkNumber = "11111";
            mSupplierList.Add(TestItem);
        }   
    }

}


