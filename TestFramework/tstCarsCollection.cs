using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstCarsCollection
    {
        [TestMethod]
        public void CarsInstanceOK()
        {
            //Create an instance of the class we want to create.
            clsCarsCollection AllCars = new clsCarsCollection();
            //Tests to see that it exists
            Assert.IsNotNull(AllCars);
        }

        [TestMethod]
        public void CarListOK()
        {
            //Create an instance of the class we want to create.
            clsCarsCollection AllCars = new clsCarsCollection();
            //Create some test data to assign to the property.
            //In this case data needs to be a list of objects.
            List<clsCar> TestList = new List<clsCar>();
            //Add item to the list
            //Create the item of test data
            clsCar TestItem = new clsCar();
            //Set it's properties
            TestItem.CarManufacturer = "Volkswagon";
            TestItem.CarModel = "Golf R";
            TestItem.CarRegistrationPlate = "DE17 FGH";
            TestItem.CarColour = "Yellow";
            TestItem.CarNumberOfDoors = 5;
            TestItem.CarNumberOfSeats = 5;
            TestItem.CarNeedsRepair = true;
            TestItem.CarSold = false;
            //Add the items to the test list.
            TestList.Add(TestItem);
            //Assign the data to the property.
            AllCars.CarList = TestList;
            //Test to see that the two values are the same.
            Assert.AreEqual(AllCars.CarList, TestList);

        }


        [TestMethod]
        public void CarsThisCarPropertyOk()
        {
            //Create an instance of the class we want to create.
            clsCarsCollection AllCars = new clsCarsCollection();
            //Create some test data to assign to the property.
            clsCar TestCar = new clsCar();                   
            //Set the properties of the test object.
            TestCar.CarManufacturer = "Volkswagon";
            TestCar.CarModel = "Golf R";
            TestCar.CarRegistrationPlate = "DE17 FGH";
            TestCar.CarColour = "Yellow";
            TestCar.CarNumberOfDoors = 5;
            TestCar.CarNumberOfSeats = 5;
            TestCar.CarNeedsRepair = true;
            TestCar.CarSold = false;
            //Assign the data to the property.
            AllCars.ThisCar = TestCar;
            //Test to see that the two values are the same.
            Assert.AreEqual(AllCars.ThisCar, TestCar);
        }

        [TestMethod]
        public void CarsListAndCountOK()
        {
            //Create an instance of the class we want to create.
            clsCarsCollection AllCars = new clsCarsCollection();
            //Create some test data to assign to the property.
            //In this case data needs to be a list of objects.
            List<clsCar> TestList = new List<clsCar>();
            //Add item to the list
            //Create the item of test data
            clsCar TestItem = new clsCar();
            //Set it's properties
            TestItem.CarManufacturer = "Volkswagon";
            TestItem.CarModel = "Golf R";
            TestItem.CarRegistrationPlate = "DE17 FGH";
            TestItem.CarColour = "Yellow";
            TestItem.CarNumberOfDoors = 5;
            TestItem.CarNumberOfSeats = 5;
            TestItem.CarNeedsRepair = true;
            TestItem.CarSold = false;
            //Add the items to the test list.
            TestList.Add(TestItem);
            //Assign the data to the property.
            AllCars.CarList = TestList;
            //Test to see that the two values are the same.
            Assert.AreEqual(AllCars.Count, TestList.Count);
        }


        [TestMethod]
        public void CarAddMethodOK()
        {
            //Create an instance of the class we want to create
            clsCarsCollection AllCars = new clsCarsCollection();
            //Create the item for test data.
            clsCar TestItem = new clsCar();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.CarID = 1;
            TestItem.CarManufacturer = "Mini";
            TestItem.CarModel = "Paceman";
            TestItem.CarRegistrationPlate = "FE64 JUI";
            TestItem.CarColour = "White";
            TestItem.CarNumberOfDoors = 5;
            TestItem.CarNumberOfSeats = 4;
            TestItem.TransactionID = 123243243;
            TestItem.CarNeedsRepair = false;
            TestItem.CarSold = false;
            //Set thiscar to the test data.
            AllCars.ThisCar = TestItem;
            //Find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //Test to see if the two values are the same.
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void CarDeleteMethodOK()
        {
            //create an instance of the class we want to create.
            clsCarsCollection AllCars = new clsCarsCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //variable to store the primary key.
            Int32 PrimaryKey = 0;
            //set it's properties.
            TestItem.CarID = 4;
            TestItem.CarManufacturer = "BMW";
            TestItem.CarModel = "i8";
            TestItem.CarRegistrationPlate = "FE17 GTE";
            TestItem.CarColour = "yellow";
            TestItem.CarNumberOfDoors = 5;
            TestItem.CarNumberOfSeats = 5;
            TestItem.CarNeedsRepair = false;
            TestItem.CarSold = true;
            //set thiscar to the test date
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data.
            TestItem.CarID = PrimaryKey;
            //find the record.
            AllCars.ThisCar.Find(PrimaryKey);
            //delete the record.
            AllCars.Delete();
            //now find the record.
            Boolean Found = AllCars.ThisCar.Find(PrimaryKey);
            //Test to see that the record was not found.
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void CarUpdateMethodOk()
        {
            //create an instance of the class we want to create.
            clsCarsCollection AllCars = new clsCarsCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //variable to store the primary key.
            Int32 PrimaryKey = 0;
            //set it's properties.
            TestItem.CarManufacturer = "BMW";
            TestItem.CarModel = "i8";
            TestItem.CarRegistrationPlate = "FE17 GTE";
            TestItem.CarColour = "yellow";
            TestItem.CarNumberOfDoors = 5;
            TestItem.CarNumberOfSeats = 5;
            TestItem.CarNeedsRepair = false;
            TestItem.CarSold = true;
            //set thiscar to the test date
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data.
            TestItem.CarID = PrimaryKey;
            //Modify the test data
            TestItem.CarManufacturer = "Audi";
            TestItem.CarModel = "s5";
            TestItem.CarRegistrationPlate = "FE15 EDS";
            TestItem.CarColour = "White";
            TestItem.CarNumberOfDoors = 3;
            TestItem.CarNumberOfSeats = 5;
            TestItem.CarNeedsRepair = true;
            TestItem.CarSold = false;
            //set the record based on the new test data
            AllCars.ThisCar = TestItem;
            //update the record
            AllCars.Update();
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see ThisCar matches the test data.
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void FilterByCarManufacturerMethodOk()
        {
            //Create an instance of the class containing unfiltered results.
            clsCarsCollection AllCars = new clsCarsCollection();
            //create an instance of the filtered data.
            clsCarsCollection FilteredCars = new clsCarsCollection();
            //Apply a blank string (Should return all records)
            FilteredCars.FilterByCarManufacturer("");
            //Test to see that the two values are the same.
            Assert.AreEqual(AllCars.Count, FilteredCars.Count);
            
        }

        [TestMethod]
        public void FilterByCarManufacturerNoneFound()
        {
            //create an instance of the filtered data.
            clsCarsCollection FilteredCars = new clsCarsCollection();
            //Apply a blank string (Should return all records)
            FilteredCars.FilterByCarManufacturer("TestManufacturer");
            //Test to see that there are no records.
            Assert.AreEqual(0, FilteredCars.Count);
        }

        [TestMethod]
        public void FilterByCarManufacturerDataFound()
        {
            //create an instance of the filtered data.
            clsCarsCollection FilteredCars = new clsCarsCollection();
            //Variable to store the result.
            Boolean Ok = true;
            //apply a car manufacturer that doesn't exist.
            FilteredCars.FilterByCarManufacturer("Doesntexist");
            //check that the correct number of records are found.
            if (FilteredCars.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredCars.CarList[0].CarID != 1)
                {
                    Ok = false;
                }
                //check that the first record is ID 2
                if (FilteredCars.CarList[1].CarID != 2)
                {
                    Ok = false;
                }
                else
                {
                    Ok = false;
                }
                //test to see that there are no records.
                Assert.IsTrue(Ok);
            }
        }





    }
}
