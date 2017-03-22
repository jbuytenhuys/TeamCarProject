using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstCarRepairsCollection
    {
        [TestMethod]
        public void CarRepairInstanceOK()
        {
            //Create an instance of the class
            clsCarRepairsCollection AllCarRepairs = new clsCarRepairsCollection();
            //Test to see if it exists
            Assert.IsNotNull(AllCarRepairs);
        }

        [TestMethod]
        public void CarRepairListOK()
        {
            //Create an instance of the class
            clsCarRepairsCollection AllCarRepairs = new clsCarRepairsCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCarRepairs> TestList = new List<clsCarRepairs>();
            //Add an item to the list
            //create the item of test data
            clsCarRepairs TestItem = new clsCarRepairs();
            //Set its properties
            TestItem.CarRepairID = 1;
            TestItem.DaysInForRepair = 30;
            TestItem.DeadlineDate = DateTime.Now.Date;
            TestItem.PartPrice = 99.99m;
            TestItem.PartRequired = "Test part";
            TestItem.RepairStatus = true;
            //Add the item to the list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCarRepairs.CarRepairList = TestList;
            //Test to see if the two values are the same
            Assert.AreEqual(AllCarRepairs.CarRepairList, TestList);
        }

        [TestMethod]
        public void ThisCarRepairPropertyOK()
        {
            //Create an instance of the class
            clsCarRepairsCollection AllCarRepairs = new clsCarRepairsCollection();
            //create tsome test data to assign to the property
            clsCarRepairs TestCarRepair = new clsCarRepairs();
            //Set the properties of the test object
            TestCarRepair.CarRepairID = 1;
            TestCarRepair.DaysInForRepair = 30;
            TestCarRepair.DeadlineDate = DateTime.Now.Date;
            TestCarRepair.PartPrice = 99.99m;
            TestCarRepair.PartRequired = "Test part";
            TestCarRepair.RepairStatus = true;
            //Assign the data to the property
            AllCarRepairs.ThisCarRepair = TestCarRepair;
            //Test to see if the two values are the same
            Assert.AreEqual(AllCarRepairs.ThisCarRepair, TestCarRepair);
        }

        [TestMethod]
        public void CarRepairListAndCountOK()
        {
            //Create an instance of the class
            clsCarRepairsCollection AllCarRepairs = new clsCarRepairsCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCarRepairs> TestList = new List<clsCarRepairs>();
            //Add an item to the list
            //create the item of test data
            clsCarRepairs TestItem = new clsCarRepairs();
            //Set its properties
            TestItem.DaysInForRepair = 30;
            TestItem.DeadlineDate = DateTime.Now.Date;
            TestItem.PartPrice = 99.99m;
            TestItem.PartRequired = "Test part";
            TestItem.RepairStatus = true;
            //Add the item to the list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCarRepairs.CarRepairList = TestList;
            //Test to see if the two values are the same
            Assert.AreEqual(AllCarRepairs.Count, TestList.Count);
        }
    }
}
