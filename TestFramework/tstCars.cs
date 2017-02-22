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
        public void FindManufacturerMethodOK()
        {
            clsCar AnCarManufacturer = new clsCar();
            Boolean Found = false;
            string CarManufactuer = "BMW";
            Found = AnCarManufacturer.Find(CarManufactuer);
            Assert.IsTrue(Found);
        }

    }
}
