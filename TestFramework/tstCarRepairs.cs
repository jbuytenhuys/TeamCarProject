using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();

            Assert.IsNotNull(AnCarRepair);
        }

        [TestMethod]
        public void CarManufacturerOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            string TestData = "Seat";
            AnCarRepair.CarManufacturer = TestData;
            Assert.AreEqual(AnCarRepair.CarManufacturer, TestData);
        }

        [TestMethod]
        public void CarModelOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            string TestData = "Ibiza";
            AnCarRepair.CarModel = TestData;
            Assert.AreEqual(AnCarRepair.CarModel, TestData);
        }

        [TestMethod]
        public void DaysInForRepairOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            Int32 TestData = 32;
            AnCarRepair.DaysInForRepair = TestData;
            Assert.AreEqual(AnCarRepair.DaysInForRepair, TestData);
        }

        [TestMethod]
        public void DeadlineDateOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            DateTime TestData = DateTime.Now.Date;
            AnCarRepair.DeadlineDate = TestData;
            Assert.AreEqual(AnCarRepair.DeadlineDate, TestData);
        }

        [TestMethod]
        public void PartPriceOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            decimal TestData = 1699.99m;
            AnCarRepair.PartPrice = TestData;
            Assert.AreEqual(AnCarRepair.PartPrice, TestData);
        }

        [TestMethod]
        public void PartRequiredOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            string TestData = "Engine";
            AnCarRepair.PartRequired = TestData;
            Assert.AreEqual(AnCarRepair.PartRequired, TestData);
        }

        [TestMethod]
        public void RepairStatusOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            Boolean TestData = true;
            AnCarRepair.RepairStatus = TestData;
            Assert.AreEqual(AnCarRepair.RepairStatus, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            Boolean Found = false;
            Int32 CarRepairID = 1;
            Found = AnCarRepair.Find(CarRepairID);
            Assert.IsTrue(Found);
            //njdsfhbdfshbdsfjbsaliodhkabfkjsdbfjkdbfkjsbdfkjbsdkjfbskjdbfksjbdf
        }
    }
}
