﻿using System;
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
            
            //Add the item to the list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCarRepairs.CarRepairList = TestList;
            //Test to see if the two values are the same
            Assert.AreEqual(AllCarRepairs.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class
            clsCarRepairsCollection AllCarRepairs = new clsCarRepairsCollection();
            //create the item of test data
            clsCarRepairs TestItem = new clsCarRepairs();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.CarRepairID = 2000;
            TestItem.DaysInForRepair = 27;
            TestItem.DeadlineDate = DateTime.Now.Date.AddDays(60);
            TestItem.PartPrice = 52.99m;
            TestItem.PartRequired = "Add test";
            
            TestItem.CarID = 2000;
            TestItem.StaffID = 2000;
            //set this repair to the test data
            AllCarRepairs.ThisCarRepair = TestItem;
            //add the record
            PrimaryKey = AllCarRepairs.Add();
            //set the primary key of the test data
            TestItem.CarRepairID = PrimaryKey;
            //find the record
            AllCarRepairs.ThisCarRepair.Find(PrimaryKey);
            //Test to see if the two values are the same
            Assert.AreEqual(AllCarRepairs.ThisCarRepair, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance of the class
            clsCarRepairsCollection AllCarRepairs = new clsCarRepairsCollection();
            //create the item of test data
            clsCarRepairs TestItem = new clsCarRepairs();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.CarRepairID = 8;
            TestItem.DaysInForRepair = 1;
            TestItem.DeadlineDate = DateTime.Now.Date.AddDays(9);
            TestItem.PartPrice = 200.00m;
            TestItem.PartRequired = "4 new tyres";
            //set this repair to the test data
            AllCarRepairs.ThisCarRepair = TestItem;
            //add the record
            PrimaryKey = AllCarRepairs.Add();
            //set the primary key of the test data
            TestItem.CarRepairID = PrimaryKey;
            //find the record
            AllCarRepairs.ThisCarRepair.Find(PrimaryKey);
            //Delete the record
            AllCarRepairs.Archive();
            //Now find the record
            Boolean Found = AllCarRepairs.ThisCarRepair.Find(PrimaryKey);
            //Test to see if the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an instance of the class
            clsCarRepairsCollection AllCarRepairs = new clsCarRepairsCollection();
            //create the item of test data
            clsCarRepairs TestItem = new clsCarRepairs();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.DaysInForRepair = 1;
            TestItem.DeadlineDate = DateTime.Now.Date.AddDays(9);
            TestItem.PartPrice = 200.00m;
            TestItem.PartRequired = "4 new tyres";
            
            //set this repair to the test data
            AllCarRepairs.ThisCarRepair = TestItem;
            //add the record
            PrimaryKey = AllCarRepairs.Add();
            //set the primary key of the test data
            TestItem.CarRepairID = PrimaryKey;
            //Modify the data
            TestItem.DaysInForRepair = 2;
            TestItem.DeadlineDate = DateTime.Now.Date.AddDays(12);
            TestItem.PartPrice = 210.00m;
            TestItem.PartRequired = "7 new tyres";
            
            //set this repair to the new test data
            AllCarRepairs.ThisCarRepair = TestItem;
            //Update the record
            AllCarRepairs.Update();
            //find the record
            AllCarRepairs.ThisCarRepair.Find(PrimaryKey);
            //Test to see if the two values are the same
            Assert.AreEqual(AllCarRepairs.ThisCarRepair, TestItem);
        }

        [TestMethod]
        public void FilterByPartRequiredMethodOK()
        {
            //Create an instance of the class containing unfiltered results
            clsCarRepairsCollection AllCarRepairs = new clsCarRepairsCollection();
            //Create an instance of the class containing filtered results
            clsCarRepairsCollection FilteredCarRepairs = new clsCarRepairsCollection();
            //apply a blank string
            FilteredCarRepairs.FilterByPartRequired("");
            //test to see two values are the same
            Assert.AreEqual(AllCarRepairs.Count, FilteredCarRepairs.Count);
        }

        [TestMethod]
        public void FilterByPartRequiredNoneFound()
        {
            //Create an instance of the class containing filtered results
            clsCarRepairsCollection FilteredCarRepairs = new clsCarRepairsCollection();
            //apply a blank string
            FilteredCarRepairs.FilterByPartRequired("XXXX");
            //test to see two values are the same
            Assert.AreEqual(0, FilteredCarRepairs.Count);
        }
    }
}
