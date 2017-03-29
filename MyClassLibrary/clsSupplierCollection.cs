using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
            }
        }
        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
           }
        }
        public clsSupplier ThisSupplier { get; set; }
    }

}