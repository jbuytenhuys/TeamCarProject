using MyClassLibrary;
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

        public clsSupplierCollection()
        {
            clsSupplier TestItem = new clsSupplier();
            TestItem.Address = "1b";
            TestItem.City = "Birmingham";
            TestItem.County = "eastmidlands";
            TestItem.DateAdded = System.DateTime.Now.Date;
            TestItem.Mobile = "078";
            TestItem.Name = "Mark";
            TestItem.PostCode = "CV6";
            TestItem.PostionInCompany = "1bbbbbbbbbbbbbbbbbbbbbb25";
            TestItem.SupplierName = "Audi";
            TestItem.Title = "Mr";
            TestItem.WorkExt = "312";
            TestItem.WorkNumber = "12134";
            mSupplierList.Add(TestItem);
            TestItem = new clsSupplier();
            TestItem.Address = "2b";
            TestItem.City = "Coventry";
            TestItem.County = "Westmidlands";
            TestItem.DateAdded = System.DateTime.Now.Date;
            TestItem.Mobile = "012";
            TestItem.Name = "Smith";
            TestItem.PostCode = "Cv8";
            TestItem.PostionInCompany = "1ccbbbbbbbbbbbbbbbbbbbb25";
            TestItem.SupplierName = "BMW";
            TestItem.Title = "Mrs";
            TestItem.WorkExt = "222";
            TestItem.WorkNumber = "11111";
            mSupplierList.Add(TestItem);
        }

    }
}

     



