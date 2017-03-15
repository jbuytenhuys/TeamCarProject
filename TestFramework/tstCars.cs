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
            //Create an instance of the class we want to create.
            clsCar AnCar = new clsCar();
            //Test to see if it exists.
            Assert.IsNotNull(AnCar);
        }

        [TestMethod]
        public void CarManufacturerOK()
        {
            //Create an instance of the class we want to create.
            clsCar AnCar = new clsCar();
            //Create some test data assign to the property.
            string TestData = "VolksWagen";
            //Assign the data to the property.
            AnCar.CarManufacturer = TestData;
            //Test to see if the two values are equal.
            Assert.AreEqual(AnCar.CarManufacturer, TestData);
        }

        [TestMethod]
        public void CarModelOK()
        {
            //Create an instance of the class we want to create.
            clsCar AnCar = new clsCar();
            //Create some test data assign to the property.
            string TestData = "Golf";
            //Assign the data to the property.
            AnCar.CarModel = TestData;
            //Test to see if the two values are equal.
            Assert.AreEqual(AnCar.CarModel, TestData);
        }

        [TestMethod]
        public void CarColourOK()
        {
            //Create an instance of the class we want to create.
            clsCar AnCar = new clsCar();
            //Create some test data assign to the property.
            string TestData = "Blue";
            //Assign the data to the property.
            AnCar.CarColour = TestData;
            //Test to see if the two values are equal.
            Assert.AreEqual(AnCar.CarColour, TestData);
        }

        [TestMethod]
        public void CarRegistrationPlateOK()
        {
            //Create an instance of the class we want to create.
            clsCar AnCar = new clsCar();
            //Create some test data assign to the property.
            string TestData = "GV06 DTN";
            //Assign the data to the property.
            AnCar.CarRegistrationPlate = TestData;
            //Test to see if the two values are equal.
            Assert.AreEqual(AnCar.CarRegistrationPlate, TestData);
        }

        [TestMethod]
        public void CarNeedsRepairOK()
        {
            //Create an instance of the class we want to create.
            clsCar AnCar = new clsCar();
            //Create some test data assign to the property.
            Boolean TestData = true;
            //Assign the data to the property.
            AnCar.CarNeedsRepair = TestData;
            //Test to see if the two values are equal.
            Assert.AreEqual(AnCar.CarNeedsRepair, TestData);
        }

        [TestMethod]
        public void CarNumberOfDoorsOK()
        {
            //Create an instance of the class we want to create.
            clsCar AnCar = new clsCar();
            //Create some test data assign to the property.
            Int32 TestData = 5;
            //Assign the data to the property.
            AnCar.CarNumberOfDoors = TestData;
            //Test to see if the two values are equal.
            Assert.AreEqual(AnCar.CarNumberOfDoors, TestData);
        }

        [TestMethod]
        public void CarNumberOfSeatsOK()
        {
            //Create an instance of the class we want to create.
            clsCar AnCar = new clsCar();
            //Create some test data assign to the property.
            Int32 TestData = 7;
            //Assign the data to the property.
            AnCar.CarNumberOfSeats = TestData;
            //Test to see if the two values are equal.
            Assert.AreEqual(AnCar.CarNumberOfSeats, TestData);
        }

        [TestMethod]
        public void CarSoldOK()
        {
            //Create an instance of the class we want to create.
            clsCar AnCar = new clsCar();
            //Create some test data assign to the property.
            Boolean TestData = true;
            //Assign the data to the property.
            AnCar.CarSold = TestData;
            //Test to see if the two values are equal.
            Assert.AreEqual(AnCar.CarSold, TestData);
        }

        [TestMethod]
        public void CarFindMethodOK()
        {
            //Create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //Create a boolean variable to store the result of validation.
            Boolean Found = false;
            //Create some test data to use with the method.
            Int32 CarID = 2;
            //Invoke the method.
            Found = AnCarID.Find(CarID);
            //Test to see that the result is correct.
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
            if (AnCarID.CarModel != "i8")
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

        [TestMethod]
        public void CarValidMethodOK()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            Int32 NumOfDoors = 5;
            Int32 NumOfSeats = 5;
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCarManufacturerMinlessOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = ""; //should trigger an error.
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            Int32 NumOfDoors = 5;
            Int32 NumOfSeats = 5;
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarManufacturerMin()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "A"; //should trigger an error.
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            Int32 NumOfDoors = 5;
            Int32 NumOfSeats = 5;
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }







    }
}

