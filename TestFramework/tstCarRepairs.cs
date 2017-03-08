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
            //test to see that it exists
            Assert.IsNotNull(AnCarRepair);
        }

        [TestMethod]
        public void DaysInForRepairOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //create some test data
            Int32 TestData = 32;
            //assign data to the property
            AnCarRepair.DaysInForRepair = TestData;
            //test to see two values are the same
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
            
        }


        [TestMethod]
        public void TestPartRequiredFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarID = 1;
            Found = AnCarRepair.Find(CarID);
            if (AnCarRepair.PartRequired != "Test Part")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPartPriceFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarID = 1;
            Found = AnCarRepair.Find(CarID);
            if (AnCarRepair.PartPrice != 2.20m)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDeadlineDateFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarID = 1;
            Found = AnCarRepair.Find(CarID);
            if (AnCarRepair.DeadlineDate != Convert.ToDateTime("21/03/2017"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDaysInForRepairFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarID = 1;
            Found = AnCarRepair.Find(CarID);
            if (AnCarRepair.DaysInForRepair != 30)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestRepairStatusFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarID = 1;
            Found = AnCarRepair.Find(CarID);
            if (AnCarRepair.RepairStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarID = 1;
            Found = AnCarRepair.Find(CarID);
            if (AnCarRepair.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


    }
}
