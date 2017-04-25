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
        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
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
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);



        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
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
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            AllSuppliers.Delete();
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }


        [TestMethod]
        public void SupplierUpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
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
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            TestItem.Address = "2b";
            TestItem.City = "Coventry";
            TestItem.County = "westmidlands";
            TestItem.DateAdded = System.DateTime.Now.Date;
            TestItem.Mobile = "079";
            TestItem.Name = "john";
            TestItem.PostCode = "CV8";
            TestItem.PostionInCompany = "1cccccccc";
            TestItem.SupplierName = "bmw";
            TestItem.Title = "Mrs";
            TestItem.WorkExt = "412";
            TestItem.WorkNumber = "1214";
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }



        [TestMethod]
        public void FilterByPostCodeMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.FilterByPostCode("");
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }



    }
}






