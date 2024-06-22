using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data
            List<clsCustomer> TestList = new List<clsCustomer> ();
            //create a test customer
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ReceiveMarketing = true;
            TestItem.CustomerID = 40;
            TestItem.Name = "John Smith";
            TestItem.Email = "John@Smith.co.uk";
            TestItem.Address = "12a street";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the customer to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.ReceiveMarketing = true;
            TestCustomer.CustomerID = 40;
            TestCustomer.Name = "John Smith";
            TestCustomer.Email = "John@Smith.co.uk";
            TestCustomer.Address = "12a street";
            TestCustomer.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.ReceiveMarketing = true;
            TestItem.CustomerID = 40;
            TestItem.Name = "John Smith";
            TestItem.Email = "John@Smith.co.uk";
            TestItem.Address = "12a street";
            TestItem.DateAdded = DateTime.Now.Date;
            //add item to test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two count values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ReceiveMarketing = true;
            TestItem.CustomerID = 1;
            TestItem.Name = "John Smith";
            TestItem.Email = "John@Smith.co.uk";
            TestItem.Address = "12a street";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.ReceiveMarketing = false;
            TestItem.Name = "Billy Sparks";
            TestItem.Email = "Billy@Sparks.com";
            TestItem.Address = "32 WilloBrooke Avenue";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.ReceiveMarketing = true;
            TestItem.Name = "Sam Sparks";
            TestItem.Email = "Sam@Sparks.com";
            TestItem.Address = "34 Swallow Falls";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 10;
            TestItem.ReceiveMarketing = true;
            TestItem.Name = "Greg Solomon";
            TestItem.Email = "Greg@Solomon.com";
            TestItem.Address = "37 Pillow Road";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a name that doesn't exist
            FilteredCustomers.ReportByName("xxxx xxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a name
            FilteredCustomers.ReportByName("YYYY YYYY");
            //check that the correct number of records are found
            if(FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 30
                if(FilteredCustomers.CustomerList[0].CustomerID != 30)
                {
                    OK = false;
                }
                //check to see that the second record ID is 34
                if(FilteredCustomers.CustomerList[1].CustomerID != 34)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are two records
            Assert.IsTrue(OK);
        }
    }
}