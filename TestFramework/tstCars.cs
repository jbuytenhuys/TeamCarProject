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
            Int32 CarID = 1;
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
            Int32 CarID = 1;
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
            Int32 CarID = 1;
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
            Int32 CarID = 1;
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
            Int32 CarID = 1;
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
            Int32 CarID = 1;
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
            Int32 CarID = 1;
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
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
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
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
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
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarManufacturerMinPlusOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "AA"; //should be okay.
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarManufacturerMaxLessOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "31CharactersLongAAAAAAAAAAAAAAA"; //should be okay
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCarManufacturerMax()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "32CharactersLongAAAAAAAAAAAAAAAA"; //should be okay
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarManufacturerMid()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "16CharactersLong"; //should be okay
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarManufacturerMaxPlusOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "33CharactersLongAAAAAAAAAAAAAAAAA"; //should fail.
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarManufacturerExtremeMax()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "";
            CarManufacturer = CarManufacturer.PadRight(50, 'A'); //should fail.
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarModelMinlessOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi"; 
            string CarModel = ""; //should trigger an error.
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarModelMin()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "A"; //should be okay.
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarModelMinPlusOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "AA"; //should be okay.
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";            
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarModelMaxLessOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "31CharactersLongAAAAAAAAAAAAAAA"; //should be okay.
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarModelMax()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "32CharactersLongAAAAAAAAAAAAAAA"; //should be okay.
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarModelMaxPlusOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "33CharactersLongAAAAAAAAAAAAAAAAA"; //should trigger an error.
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarModelMaxExtreme()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "";
            CarModel = CarModel.PadRight(50, 'A'); //should trigger an error.
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarModelMid()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "16CharactersLong";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarRegistrationMinLessOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = ""; //should return an error
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarRegistrationMin()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "A"; //should be okay
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarRegistrationMinPlusOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "AA"; //should be okay
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarRegistrationMid()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "AAAA"; //should be okay
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarRegistrationMaxLessOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "AAA AAA"; //should be okay
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

    
        [TestMethod]
        public void TestCarRegistrationMax()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "AAAA AAA"; //should be okay
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarRegistrationMaxPlusOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "AAAA AAAA"; //should return an error
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void TestCarRegistrationMaxExtreme()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "16CharactersLong"; //should return an error
            string CarColour = "Yellow";
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void TestCarColourMinLessOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = ""; //should return an error
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarColourMin()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "A"; //should be okay.
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarColourMinPlusOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "AA"; //should be okay.
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarColourMaxLessOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "31CharactersLongAAAAAAAAAAAAAAA"; //should be okay.
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarColourMax()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "32CharactersLongAAAAAAAAAAAAAAAA"; //should be okay.
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarColourMaxPlusOne()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "33CharactersLongAAAAAAAAAAAAAAAAA"; //should return an error.
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarColourMid()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "16CharactersLong"; //should be okay.
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarColourMaxExtreme()
        {
            //create an instance of the class we want to create.
            clsCar AnCarID = new clsCar();
            //boolean variable to store the result of search
            Boolean OK = false;
            //Create some test data to use with the method.
            string CarManufacturer = "Audi";
            string CarModel = "RS4";
            string CarRegistrationPlate = "FH63 GTE";
            string CarColour = "";
            CarColour = CarColour.PadRight(50, 'A'); //should trigger an error.
            string NumOfDoors = "5";
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarNumberOfDoorsMinExtreme()
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
            string NumOfDoors = "-32"; //should return error.
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarNumberOfDoorsMinLessOne()
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
            string NumOfDoors = "1"; //should return an error.
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarNumberOfDoorsMin()
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
            string NumOfDoors = "2"; //should be okay.
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNumberOfDoorsMinPlusOne()
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
            string NumOfDoors = "3"; //should be okay.
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNumberOfDoorsMaxLessOne()
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
            string NumOfDoors = "4"; //should be okay.
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNumberOfDoorsMax()
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
            string NumOfDoors = "5"; //should be okay.
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNumberOfDoorsMaxPlusOne()
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
            string NumOfDoors = "6"; //should return an error
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarNumberOfDoorsMid()
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
            string NumOfDoors = "3"; //should be okay.
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNumberOfDoorsMaxExtreme()
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
            string NumOfDoors = "32"; //should return error.
            string NumOfSeats = "5";
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarNumberOfSeatsMinExtreme()
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
            string NumOfDoors = "5";
            string NumOfSeats = "-32"; //should return error.
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarNumberOfSeatsMinLessOne()
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
            string NumOfDoors = "5";
            string NumOfSeats = "0"; //should return error.
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarNumberOfSeatsMin()
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
            string NumOfDoors = "5";
            string NumOfSeats = "1"; //should be okay.
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNumberOfSeatsMinPlusOne()
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
            string NumOfDoors = "5";
            string NumOfSeats = "2"; //should be okay.
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNumberOfSeatsMaxLessOne()
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
            string NumOfDoors = "5";
            string NumOfSeats = "6"; //should be okay.
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNumberOfSeatsMax()
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
            string NumOfDoors = "5";
            string NumOfSeats = "7"; //should be okay.
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNumberOfSeatsMaxPlusOne()
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
            string NumOfDoors = "5";
            string NumOfSeats = "8"; //should be return an error.
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void TestCarNumberOfSeatsMaxExtreme()
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
            string NumOfDoors = "5";
            string NumOfSeats = "32"; //should be return an error.
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCarNumberOfSeatsMid()
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
            string NumOfDoors = "5";
            string NumOfSeats = "5"; //should be okay.
            string SupplierID = "2";
            //Invoke the method
            OK = AnCarID.Valid(CarManufacturer, CarModel, CarRegistrationPlate, CarColour, NumOfDoors, NumOfSeats, SupplierID);
            //Test to see that the result is correct.
            Assert.IsTrue(OK);
        }
    }
}

