using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member to the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //to worry about later
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        public clsOrderCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the arraylist with the datatable
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new record to the database based on the new value of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the store procedure
            DB.AddParameter("@Phonenumber", mThisOrder.PhoneNumber);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@DeliveryTime",mThisOrder.DeliveryTime);
            DB.AddParameter("@Delivery",mThisOrder.Delivery);
            DB.AddParameter("@DeliveryAddress",mThisOrder.DeliveryAddress);
            DB.AddParameter("@Notes",mThisOrder.Notes);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@Phonenumber", mThisOrder.PhoneNumber);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@DeliveryTime", mThisOrder.DeliveryTime);
            DB.AddParameter("@Delivery", mThisOrder.Delivery);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@Notes", mThisOrder.Notes);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByDeliveryAddress(string DeliveryAddress)
        {
            //filter the record based on a full or partial delivery address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the delivery address parameter to the database
            DB.AddParameter("@DeliveryAddress", DeliveryAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByDeliveryAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            mOrderList = new List<clsOrder>();

            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();

                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.PhoneNumber = Convert.ToInt64(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnOrder.Delivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["Delivery"]);
                AnOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AnOrder.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
                AnOrder.DeliveryTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryTime"]);
                AnOrder.Notes = Convert.ToString(DB.DataTable.Rows[Index]["Notes"]);

                mOrderList.Add(AnOrder);

                Index++;
            }
        }
    }
}