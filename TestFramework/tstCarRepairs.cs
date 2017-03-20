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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //test to see that it exists
            Assert.IsNotNull(AnCarRepair);
        }

        [TestMethod]
        public void DaysInForRepairOK()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
            clsCarRepairs AnCarRepair = new clsCarRepairs();
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
        public void DeadlineDateExtremeMin()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-100);
            string DeadlineDate = TestDate.ToString();
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DeadlineDateMinLessOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DeadlineDate = TestDate.ToString();
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DeadlineDateMin()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DeadlineDate = TestDate.ToString();
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DeadlineDateMinplusOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DeadlineDate = TestDate.ToString();
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DeadlineDateMaxLessOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(59);
            string DeadlineDate = TestDate.ToString();
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DeadlineDateMax()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(60);
            string DeadlineDate = TestDate.ToString();
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DeadlineDateMaxPlusOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(61);
            string DeadlineDate = TestDate.ToString();
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DeadlineDateExtremeMax()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1000);
            string DeadlineDate = TestDate.ToString();
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DeadlineDateInvalidData()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 10;
            decimal PartPrice = 12.99m;
            string PartRequired = "Some part";
            //Enter type that is not a date
            string DeadlineDate = "Invalid data";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PartRequiredMinLessOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PartRequiredMin()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "A";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PartRequiredMinPlusOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "AA";
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PartRequiredMaxLessOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(31, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PartRequiredMax()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(32, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PartRequiredMaxPlusOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(33, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PartRequiredExtremeMax()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(1000, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PartRequiredMid()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 12.99m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PartPriceExtremeMin()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = -100m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PartPriceMinLessOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 0m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PartPriceMin()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 1m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PartPriceMinPlusOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 2m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PartPriceMaxLessOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 9999m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PartPriceMax()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 10000m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PartPriceMaxPlusOne()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 10001m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PartPriceExtremeMax()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 1000000m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PartPriceMid()
        {
            //create instance
            clsCarRepairs AnCarRepair = new clsCarRepairs();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            Int32 DaysInForRepair = 30;
            string DeadlineDate = DateTime.Now.Date.ToString();
            decimal PartPrice = 5000m;
            string PartRequired = "";
            PartRequired = PartRequired.PadRight(16, 'A');
            //Invoke the method
            OK = AnCarRepair.Valid(DaysInForRepair, DeadlineDate, PartPrice, PartRequired);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }




    }
}
