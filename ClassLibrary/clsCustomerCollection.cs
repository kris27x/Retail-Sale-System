using System;
using System.Collections.Generic;

namespace ClassLibrary
    
{

    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        

        
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //....
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the ArrayList with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@ReceiveMarketing", mThisCustomer.ReceiveMarketing);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@ReceiveMarketing", mThisCustomer.ReceiveMarketing);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByName(string Name)
        {
            //filters the record based on a full or partial name
            clsDataConnection DB = new clsDataConnection();
            //send the Name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByName");
            //populate the ArrayList with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private ArrayList
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.ReceiveMarketing = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReceiveMarketing"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}