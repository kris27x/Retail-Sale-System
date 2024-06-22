using System;

namespace ClassLibrary
{
    public class clsCustomer
    {

        private Int32 mCustomerId;
        private DateTime mDateAdded;
        private String mAddress;
        private String mEmail;
        private String mName;
        private Boolean mReceiveMarketing;


        public bool ReceiveMarketing
        {
            get
            {
                return mReceiveMarketing;
            }
            set
            {
                mReceiveMarketing = value;
            }
        }
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

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        public bool Find(int customerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer ID to search for
            DB.AddParameter("@CustomerID", customerId);
            //execute the stored procedure
            DB.Execute("dbo.sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mReceiveMarketing = Convert.ToBoolean(DB.DataTable.Rows[0]["ReceiveMarketing"]);
                
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

        public string Valid(string name, string email, string address, string dateAdded)
        {
            String error = "";
            DateTime dateTemp;

            if(name.Length == 0)
            {
                error = error + "Name may not be blank : ";
            }

            if (name.Length > 50)
            {
                error = error + "Name must be less than 51 characters : ";
            }

            if(email.Length == 0)
            {
                error = error + "Email may not be blank : ";
            }
            
            if(email.Length > 50)
            {
                error = error + "The email must be less than 51 characters : ";
            }

            if(address.Length == 0)
            {
                error = error + "The address may not be blank : ";
            }
            
            if(address.Length > 50)
            {
                error = error + "The address must be less than 51 characters : ";
            }

            try
            {
                //copy the dateAdded value to the dateTemp variable
                dateTemp = Convert.ToDateTime(dateAdded);
                if (dateTemp < DateTime.Now.Date)
                {
                    error = error + "The date cannot be in the past : ";
                }

                if (dateTemp > DateTime.Now.Date)
                {
                    error = error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                error = error + "The date was not a valid date : ";
            }


            return error;
        }
    }
}