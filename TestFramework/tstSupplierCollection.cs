using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
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
    }
}

