using System;

namespace MyClassLibrary
{
    public class clsCarRepair
    {
        public string CarManufacturer { get; set; }
        public string CarModel { get; set; }
        public int DaysInForRepair { get; set; }
        public DateTime DeadlineDate { get; set; }
        public decimal PartPrice { get; set; }
        public string PartRequired { get; set; }
        public bool RepairStatus { get; set; }

        public bool Find(int CarRepairID)
        {
            return true;
        }
    }
}