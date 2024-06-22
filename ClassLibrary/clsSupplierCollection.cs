using System.Collections.Generic;
using System;


namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
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

        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public clsSupplier mThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public clsSupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsSupplier AnSupplier = new clsSupplier();
                AnSupplier.Stock = Convert.ToString(DB.DataTable.Rows[Index]["Stock"]);
                AnSupplier.SupplierFeedback = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierFeedback"]);
                AnSupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSupplier.SupplierProduct = Convert.ToString(DB.DataTable.Rows[Index]["SupplierProduct"]);
                AnSupplier.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                mSupplierList.Add(AnSupplier);
                Index++;

            }



            {
                clsSupplier TestItem = new clsSupplier();
                TestItem.Stock = "1";
                TestItem.SupplierFeedback = 5;
                TestItem.SupplierId = 1;
                TestItem.SupplierProduct = "orange Bike";
                TestItem.DeliveryDate = DateTime.Now.Date;
                TestItem.Price = 200;
                mSupplierList.Add(TestItem);
                TestItem = new clsSupplier();
                TestItem.Stock = "2";
                TestItem.DeliveryDate = DateTime.Now.Date;
                TestItem.SupplierFeedback = 2;
                TestItem.SupplierId = 2;
                TestItem.SupplierProduct = "Blue Bike";
                TestItem.Price = 200;
                mSupplierList.Add(TestItem);


            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierProduct", mThisSupplier.SupplierProduct);
            DB.AddParameter("@SupplierFeedback", mThisSupplier.SupplierFeedback);
            DB.AddParameter("@SupplierPrice", mThisSupplier.Price);
            DB.AddParameter("@stock", mThisSupplier.Stock);
            DB.AddParameter("@DeliveryDate", mThisSupplier.DeliveryDate);
            return DB.Execute("sproc_tblSupplier_Insert");

                


        }
    }
}





