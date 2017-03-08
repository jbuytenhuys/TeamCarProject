using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class TstclsCar
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCar AnCar = new clsCar();
            Assert.IsNotNull(AnCar);
        }

        [TestMethod]
        public void CarManufacturerOK()
        {
            clsCar AnCar = new clsCar();
            string TestData = "VolksWagen";
            AnCar.CarManufacturer = TestData;
            Assert.AreEqual(AnCar.CarManufacturer, TestData);
        }

        [TestMethod]
        public void CarModelOK()
        {
            clsCar AnCar = new clsCar();
            string TestData = "Golf";
            AnCar.CarModel = TestData;
            Assert.AreEqual(AnCar.CarModel, TestData);
        }

        [TestMethod]
        public void CarColourOK()
        {
            clsCar AnCar = new clsCar();
            string TestData = "Blue";
            AnCar.CarColour = TestData;
            Assert.AreEqual(AnCar.CarColour, TestData);
        }

        [TestMethod]
        public void CarRegistrationPlateOK()
        {
            clsCar AnCar = new clsCar();
            string TestData = "GV06 DTN";
            AnCar.CarRegistrationPlate = TestData;
            Assert.AreEqual(AnCar.CarRegistrationPlate, TestData);
        }

        [TestMethod]
        public void CarNeedsRepairOK()
        {
            clsCar AnCar = new clsCar();
            Boolean TestData = true;
            AnCar.CarNeedsRepair = TestData;
            Assert.AreEqual(AnCar.CarNeedsRepair, TestData);
        }

        [TestMethod]
        public void CarNumberOfDoorsOK()
        {
            clsCar AnCar = new clsCar();
            Int32 TestData = 5;
            AnCar.CarNumberOfDoors = TestData;
            Assert.AreEqual(AnCar.CarNumberOfDoors, TestData);
        }

        [TestMethod]
        public void CarNumberOfSeatsOK()
        {
            clsCar AnCar = new clsCar();
            Int32 TestData = 7;
            AnCar.CarNumberOfSeats = TestData;
            Assert.AreEqual(AnCar.CarNumberOfSeats, TestData);
        }

        [TestMethod]
        public void CarSoldOK()
        {
            clsCar AnCar = new clsCar();
            Boolean TestData = true;
            AnCar.CarSold = TestData;
            Assert.AreEqual(AnCar.CarSold, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCar AnCarID = new clsCar();
            Boolean Found = false;
            Int32 CarID = 2;
            Found = AnCarID.Find(CarID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestManufacturerFound()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean Ok = true;
            //Create some test data to use with the method.
            Int32 CarID = 2;
            //Invoke the method.
            Found = AnCarID.Find(CarID);
            //Check the Manufacturer.
            if (AnCarID.CarManufacturer != "BMW")
            {
                Ok = false;
            }
            //test to see if the result is correct.      
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestModelFound()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean Ok = true;
            //Create some test data to use with the method.
            Int32 CarID = 2;
            //Invoke the method.
            Found = AnCarID.Find(CarID);
            //Check the Manufacturer.
            if (AnCarID.CarModel != "DAVE")
            {
                Ok = false;
            }
            //test to see if the result is correct.      
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestColourFound()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean Ok = true;
            //Create some test data to use with the method.
            Int32 CarID = 2;
            //Invoke the method.
            Found = AnCarID.Find(CarID);
            //Check the Manufacturer.
            if (AnCarID.CarColour != "Blue")
            {
                Ok = false;
            }
            //test to see if the result is correct.      
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCarRegistrationPlateFound()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean Ok = true;
            //Create some test data to use with the method.
            Int32 CarID = 2;
            //Invoke the method.
            Found = AnCarID.Find(CarID);
            //Check the Manufacturer.
            if (AnCarID.CarRegistrationPlate != "FE66 GTH")
            {
                Ok = false;
            }
            //test to see if the result is correct.      
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCarNeedsRepairFound()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean Ok = true;
            //Create some test data to use with the method.
            Int32 CarID = 2;
            //Invoke the method.
            Found = AnCarID.Find(CarID);
            //Check the Manufacturer.
            if (AnCarID.CarNeedsRepair != false)
            {
                Ok = false;
            }
            //test to see if the result is correct.      
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestNumberOfDoorsFound()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean Ok = true;
            //Create some test data to use with the method.
            Int32 CarID = 2;
            //Invoke the method.
            Found = AnCarID.Find(CarID);
            //Check the Manufacturer.
            if (AnCarID.CarNumberOfDoors != 3)
            {
                Ok = false;
            }
            //test to see if the result is correct.      
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestNumberOfSeatsFound()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean Ok = true;
            //Create some test data to use with the method.
            Int32 CarID = 2;
            //Invoke the method.
            Found = AnCarID.Find(CarID);
            //Check the Manufacturer.
            if (AnCarID.CarNumberOfSeats != 2)
            {
                Ok = false;
            }
            //test to see if the result is correct.      
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCarSoldFound()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean Found = false;
            //boolean variable to record if data is okay (assume it is).
            Boolean Ok = true;
            //Create some test data to use with the method.
            Int32 CarID = 2;
            //Invoke the method.
            Found = AnCarID.Find(CarID);
            //Check the Manufacturer.
            if (AnCarID.CarSold != false)
            {
                Ok = false;
            }
            //test to see if the result is correct.      
            Assert.IsTrue(Ok);
        }
    }
}
