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
            Int32 PrimaryKey = 2;
            //set it's properties
            TestItem.CarID = 2;
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



    }
}
