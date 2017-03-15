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
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AnCarRepair.DeadlineDate = TestData;
            //test to see two values are the same
            Assert.AreEqual(AnCarRepair.DeadlineDate, TestData);
        }

        [TestMethod]
        public void PartPriceOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //create some test data
            decimal TestData = 1699.99m;
            //assign data to the property
            AnCarRepair.PartPrice = TestData;
            //test to see two values are the same
            Assert.AreEqual(AnCarRepair.PartPrice, TestData);
        }

        [TestMethod]
        public void PartRequiredOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //create some test data
            string TestData = "Engine";
            //assign data to the property
            AnCarRepair.PartRequired = TestData;
            //test to see two values are the same
            Assert.AreEqual(AnCarRepair.PartRequired, TestData);
        }

        [TestMethod]
        public void RepairStatusOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //create some test data
            Boolean TestData = true;
            //assign data to the property
            AnCarRepair.RepairStatus = TestData;
            //test to see two values are the same
            Assert.AreEqual(AnCarRepair.RepairStatus, TestData);
        }

        [TestMethod]
        public void CarRepairFindMethodOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //Create a boolean variable to store the result of validation.
            Boolean Found = false;
            //Create some test data to use with the method.
            Int32 CarRepairID = 1;
            //Invoke the method.
            Found = AnCarRepair.Find(CarRepairID);
            //Test to see that the result is correct.
            Assert.IsTrue(Found);
            
        }


        [TestMethod]
        public void TestPartRequiredFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean OK = true;
            //Create some test data to use with the method.
            Int32 CarID = 1;
            //Invoke the method.
            Found = AnCarRepair.Find(CarID);
            //Check the PartRequired
            if (AnCarRepair.PartRequired != "Test Part")
            {
                OK = false;
            }
            //test to see if the result is correct.
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPartPriceFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean OK = true;
            //Create some test data to use with the method.
            Int32 CarID = 1;
            //Invoke the method.
            Found = AnCarRepair.Find(CarID);
            //Check the PartPrice
            if (AnCarRepair.PartPrice != 2.20m)
            {
                OK = false;
            }
            //test to see if the result is correct.
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDeadlineDateFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean OK = true;
            //Create some test data to use with the method.
            Int32 CarID = 1;
            //Invoke the method.
            Found = AnCarRepair.Find(CarID);
            //Check the DeadlineDate
            if (AnCarRepair.DeadlineDate != Convert.ToDateTime("21/03/2017"))
            {
                OK = false;
            }
            //test to see if the result is correct.
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDaysInForRepairFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean OK = true;
            //Create some test data to use with the method.
            Int32 CarID = 1;
            //Invoke the method.
            Found = AnCarRepair.Find(CarID);
            //Check the DaysInForRepair
            if (AnCarRepair.DaysInForRepair != 30)
            {
                OK = false;
            }
            //test to see if the result is correct.
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestRepairStatusFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean OK = true;
            //Create some test data to use with the method.
            Int32 CarID = 1;
            //Invoke the method.
            Found = AnCarRepair.Find(CarID);
            //Check the RepairStatus
            if (AnCarRepair.RepairStatus != true)
            {
                OK = false;
            }
            //test to see if the result is correct.
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean OK = true;
            //Create some test data to use with the method.
            Int32 CarID = 1;
            //Invoke the method.
            Found = AnCarRepair.Find(CarID);
            //Check the StaffID
            if (AnCarRepair.StaffID != 1)
            {
                OK = false;
            }
            //test to see if the result is correct.
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CarRepairValidMethodOK()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 45;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DaysInForRepairMinLessOne()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 0;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DaysInForRepairMin()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 1;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DaysInForRepairMinPlusOne()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 2;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DaysInForRepairMaxLessOne()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 59;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DaysInForRepairMax()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 60;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DaysInForRepairMid()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 60;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DaysInForRepairMaxPlusOne()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 61;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DaysInForRepairExtremeMax()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 1000000;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create instance
            clsCarRepair AnCarRepair = new clsCarRepair();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DeadlineDate = TestDate.ToString();
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }


    }
}
