using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        //private data member for the delivery address property
        private String mDeliveryAddress;
        public String DeliveryAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryAddress;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryAddress = value;
            }
        }
        
        //private data member for the PurchaseTime property
        private DateTime mDeliveryTime;
        public DateTime DeliveryTime
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryTime;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryTime = value;
            }
        }

        //private data member for the Delivery property
        private Boolean mDelivery;
        public bool Delivery
        {
            get
            {
                //this line of code sends data out of the property
                return mDelivery;
            }
            set
            {
                //this line of code allows data into the property
                mDelivery = value;
            }
        }

        //private data member for the Itemquantity property
        private Int32 mItemQuantity;
        public int ItemQuantity
        {
            get
            {
                //this line of code sends data out of the property
                return mItemQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mItemQuantity = value;
            }
        }

        //private data member for the Notes property
        private String mNotes;
        public string Notes
        {
            get
            {
                //this line of code sends data out of the property
                return mNotes;
            }
            set
            {
                //this line of code allows data into the property
                mNotes = value;
            }
        }

        //private data member for the OrderID property
        private Int64 mPhoneNumber;
        public Int64 PhoneNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mPhoneNumber;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneNumber = value;
            }
        }

        //private data member for the OrderID property
        private Int32 mOrderID;
        public Int32 OrderID 
        { 
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        
        }

        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter order ID to search for
            DB.AddParameter("OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if(DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mPhoneNumber = Convert.ToInt64(DB.DataTable.Rows[0]["PhoneNumber"]);
                mDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivery"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mDeliveryTime = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryTime"]);
                mNotes = Convert.ToString(DB.DataTable.Rows[0]["Notes"]);

                //returns that everything work okay
                return true;
                
            }
            //if no record was found
            else
            {
                //return false
                return false;
            }

        }

        public string Valid(string phoneNumber, string itemQuantity, string deliveryTime, string deliveryAddress)
        {
            String Error = "";

            DateTime DateTemp;

            Int32 ItemAmount;
            Int64 PhoneNumb;

            // Testing the Phone Number section
            try
            {
                PhoneNumb = Convert.ToInt64(phoneNumber);
                if (phoneNumber.Length <= 6)
                {
                    Error = Error + "This field should not be empty and have more than 6 digits : ";
                }

                if (phoneNumber.Length > 18)
                {
                    Error = Error + "should not be longer than 23 digits : ";
                }
            }
            catch
            {
                Error = Error + "Only digits to be insert";
            }

            // Testing the Item quantity section
            try
            {
                ItemAmount = Convert.ToInt32(itemQuantity);
                if (ItemAmount <= 0)
                {
                    Error = Error + "Item can not be zero : ";
                }

                if (ItemAmount > 16)
                {
                    Error = Error + "Sorry, Cannot purchase more than 16 Items";
                }
            }
            catch
            {
                Error = Error + "Only Int to be insert";
            }

            //Testing the delivery Time section
            try
            {
                DateTemp = Convert.ToDateTime(deliveryTime);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "Please, Allow more than a day for the delivery : ";
                }

                if (DateTemp > DateTime.Now.AddMonths(+2))
                {
                    Error = Error + " Sorry, we can only deliver within 2 month times : ";
                }
            }

            catch
            {
                Error = Error + "The date is not a valid date : ";
            }

            if (deliveryAddress.Length == 0)
            {
                Error = Error + "The field should not be blank : ";
            }

            if (deliveryAddress.Length > 149)
            {
                Error = Error + "The field cannot contain mor than 150 character : ";
            }

            if (deliveryAddress.Length > 30)
            {
                Error = Error + "The field should not exceed 30 characters : ";
            }

            return Error;


        }
    }
}