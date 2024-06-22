using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        //good test data for Valid
        string name = "john";
        string email = "john@john.com";
        string address = "13 street";
        string dateAdded = DateTime.Now.Date.ToString();
        
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void ReceiveMarketingPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.ReceiveMarketing = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.ReceiveMarketing, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateAdded = TestData;
            Assert.AreEqual(ACustomer.DateAdded, TestData);
            
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Random Address";
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);

        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Random Email";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "John Smith";
            ACustomer.Name = TestData;
            Assert.AreEqual(ACustomer.Name, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        
        

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerID != 8)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.DateAdded != Convert.ToDateTime("26/03/2022 00:00"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.Address != "14 Willow road")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.Email != "Sam@Smith.com")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.Name != "Sam Smith")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestReceiveMarketingFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 CustomerId = 8;
            found = ACustomer.Find(CustomerId);
            if (ACustomer.ReceiveMarketing != false)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //invoke the method
            error = ACustomer.Valid(name, email, address, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string name = "";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, ""); //using NotEqual because we want to see that there IS an error
        }

        [TestMethod]
        public void NameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string name = "a";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string name = "aa";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //one less than VarChar(50)
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string name = "";
            name = name.PadRight(50, 'a');
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string name = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //25
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string name = "";
            name = name.PadRight(51, 'a');
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string name = "";
            name = name.PadRight(5000, 'a');
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            //- 100 years
            testDate = testDate.AddYears(-100);
            string dateAdded = testDate.ToString();
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            //- 100 years
            testDate = testDate.AddDays(-1);
            string dateAdded = testDate.ToString();
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            string dateAdded = testDate.ToString();
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            //- 100 years
            testDate = testDate.AddDays(1);
            string dateAdded = testDate.ToString();
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            //- 100 years
            testDate = testDate.AddYears(100);
            string dateAdded = testDate.ToString();
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string dateAdded = "this is not a date!";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string email = "";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, ""); //using NotEqual because we want to see that there IS an error
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string email = "a";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string email = "aa";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //one less than VarChar(50)
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string email = "";
            email = email.PadRight(50, 'a');
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string email = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //25
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string email = "";
            email = email.PadRight(51, 'a');
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string email = "";
            email = email.PadRight(5000, 'a');
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string address = "";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, ""); //using NotEqual because we want to see that there IS an error
        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string address = "a";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string address = "aa";
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //one less than VarChar(50)
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string address = "";
            address = address.PadRight(50, 'a');
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string address = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //25
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string address = "";
            address = address.PadRight(51, 'a');
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String error = "";
            string address = "";
            address = address.PadRight(5000, 'a');
            error = ACustomer.Valid(name, email, address, dateAdded);
            Assert.AreNotEqual(error, "");
        }
    }
}
