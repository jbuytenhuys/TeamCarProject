using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCarRepairsCollection
    {
        //Private data member for the list
        List<clsCarRepairs> mCarRepairList = new List<clsCarRepairs>();
        
        public clsCarRepairsCollection()
        {
            //PAGE 119 WRITE SHIT HERE
        }

        public List<clsCarRepairs> CarRepairList
        {
            get
            {
                //return the private data
                return mCarRepairList;
            }
            set
            {
                //set the private data
                mCarRepairList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCarRepairList.Count;
            }
            set
            {
                //worry about this later
                ;
            }
        }
        public clsCarRepairs ThisCarRepair { get; set; }
    }
}