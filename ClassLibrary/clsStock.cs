using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private bool mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
        //ItemNo private member variable
        private Int32 mItemNo;
        //ItemNo public property
        public Int32 ItemNo
        {
            get
            {
                //this line of code sends data out of the property
                return mItemNo;
            }
            set
            {
                //this line of code allows data into the property
                mItemNo = value;
            }
        }
        private String mItemDescription;
        public string ItemDescription
        {
            get
            {
                return mItemDescription;
            }
            set
            {
                mItemDescription = value;
            }
        }
        private Int32 mItemQuantity;
        public Int32 ItemQuantity
        {
            get
            {
                return mItemQuantity;
            }
            set
            {
                mItemQuantity = value;
            }
        }
        private double mPrice;
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {

                mPrice = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public bool Find(int ItemNo)

        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Item no to search for
            DB.AddParameter("@ItemNo", ItemNo);
            //execute the stored procedure
            DB.Execute("dbo.sproc_tblStock_FilterByItemNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["ItemNo"]);
                mItemDescription = Convert.ToString(DB.DataTable.Rows[0]["ItemDescription"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem

                return false;
            }

        }

        public string Valid(string itemDescription, string itemQuantity, string dateAdded, string price)
        {
            //create a string variable to store the error
            string error = "";

            DateTime dateNow;

            Int32 theItem;

            double thePrice;
            //if the ItemDescription is blank
            if (itemDescription.Length <= 0)
            {
                //record the error
                error = error + "the ItemDescription may not be blank :";
            }

            if (itemDescription.Length > 200)
            {
                error = error + "please insert a brief description :";
            }

            try
            {
                thePrice = Convert.ToDouble(price);
                if (thePrice < 39.99)
                {
                    error = error + "This field should not be empty and have more than 6 digits : ";
                }

                if (thePrice >= 200001.00)
                {
                    error = error + "should not be longer than 23 digits : ";
                }
            }
            catch
            {
                error = error + "Only digits to be insert";
            }

            try
            {
                //copy the dateAdded value to the dateTemp variable
                dateNow = Convert.ToDateTime(dateAdded);
                if (dateNow < DateTime.Now.Date)
                {
                    error = error + "The date cannot be in the past : ";
                }

                if (dateNow > DateTime.Now.Date)
                {
                    error = error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                error = error + "The date was not a valid date : ";
            }

            try
            {
                theItem = Convert.ToInt32(itemQuantity);
                if (theItem <= 0)
                {
                    error = error + "Item can not be zero : ";
                }

                if (theItem > 5000)
                {
                    error = error + "Sorry, Cannot purchase more than 16 Items";
                }
            }
            catch
            {
                error = error + "Only Int to be insert";
            }

            //return any error messages
            return error;

        }

        
    }
}