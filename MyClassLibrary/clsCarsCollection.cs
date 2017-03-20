using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCarsCollection
    {
        //private data member for the list.
        List<clsCar> mCarList = new List<clsCar>();

        public clsCarsCollection()
        {
            //Create the items of test data.
            clsCar TestItem = new clsCar();
            //Set it's properties. 
            TestItem.CarID = 1;
            TestItem.CarManufacturer = "Volkswagon";
            TestItem.CarModel = "Golf";
            TestItem.CarRegistrationPlate = "DE17 FGH";
            TestItem.CarColour = "Yellow";
            TestItem.CarNumberOfDoors = 5;
            TestItem.CarNumberOfSeats = 5;
            TestItem.CarNeedsRepair = true;
            TestItem.CarSold = false;
            //Add the items to the list.
            mCarList.Add(TestItem);
            //Re intialise the object for some new data.
            TestItem = new clsCar();
            //set it's properties.
            TestItem.CarID = 2;
            TestItem.CarManufacturer = "Mercedes";
            TestItem.CarModel = "A45";
            TestItem.CarRegistrationPlate = "AD15 HJK";
            TestItem.CarColour = "Blue";
            TestItem.CarNumberOfDoors = 3;
            TestItem.CarNumberOfSeats = 4;
            TestItem.CarNeedsRepair = false;
            TestItem.CarSold = false;
            //Add the items to the list.
            mCarList.Add(TestItem);

        }

        public List<clsCar> CarList
        {
            get
            { 
                //Return the private data
                return mCarList;
            }
            set
            {
                //set the private data
                mCarList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list.
                return mCarList.Count;
            }
            set
            {
                //worry about this later.
            }
        }
        public clsCar ThisCar { get; set; }
    }
}