using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {

        string PhoneNumber = "3498764567834";
        string ItemQuantity = "3";
        string DeliveryTime = DateTime.Now.Date.ToString();
        string DeliveryAddress = "to be delivered here";

        [TestMethod]
        public void InstanceOK()
        {
            //v00egd00001l.lec-admin.dmu.ac.uk
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 23;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderCodePropertyOK()
        {
            //create an instance of a class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int64 TestData = 23456787654;
            //assign the data to the property
            AnOrder.PhoneNumber = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.PhoneNumber, TestData);
        }

        [TestMethod]
        public void DeliveryTimePropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DeliveryTime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryTime, TestData);
        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign the property
            String TestData = "31 the la vegas";
            //assign the data to the property
            AnOrder.DeliveryAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryAddress, TestData);
        }

        [TestMethod]
        public void DeliveryPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test to assign the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Delivery = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.Delivery, TestData);
        }

        [TestMethod]
        public void ItemQuantityPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test to assign the property
            int TestData = 34;
            //assign the data to the property
            AnOrder.ItemQuantity = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.ItemQuantity, TestData);
        }
        [TestMethod]
        public void NotesPropertyOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test to assign the property
            String TestData = "We should win this one";
            //assign the data to the property
            AnOrder.Notes = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnOrder.Notes, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test to assign the property
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the metod
            Found = AnOrder.Find(OrderID);

            //check the method
            if (AnOrder.OrderID != 6)
            {
                OK = false;
            }

            //Test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryTimeFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.DeliveryTime != Convert.ToDateTime("20/04/2006"))
            {
                OK = false;
            }

            //test to see that the result is coorect
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.DeliveryAddress != "Test deliveryAddress")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.PhoneNumber != 23456787654)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemQuantityFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.ItemQuantity != 5)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.Delivery != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNotesFound()
        {
            //create an instance of a class we want to create
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderID = 6;

            //invoke the method
            Found = AnOrder.Find(OrderID);

            //check the property
            if (AnOrder.Notes != "We should win this one")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtMin()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int64 PhoneCall;

            PhoneCall = 345678;

            string PhoneNumber = PhoneCall.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int64 PhoneCall;

            PhoneCall = 34567896235671;

            string PhoneNumber = PhoneCall.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int64 PhoneCall;

            PhoneCall = 456789623567125679;

            string PhoneNumber = PhoneCall.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtMax()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int64 PhoneCall;

            PhoneCall = 4567896235671256739;

            string PhoneNumber = PhoneCall.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberInvalidData() 
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            String PhoneNumber = "This is not a phone number";

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int32 TestItem;

            TestItem = 0;

            string ItemQuantity = TestItem.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int32 TestItem;

            TestItem = 17;

            string ItemQuantity = TestItem.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int32 TestItem;

            TestItem = 15;

            string ItemQuantity = TestItem.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMin()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int32 TestItem;

            TestItem = 1;

            string ItemQuantity = TestItem.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int32 TestItem;

            TestItem = 2;

            string ItemQuantity = TestItem.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMinPlusOneToTest()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Int32 TestItem;

            TestItem = 10;

            string ItemQuantity = TestItem.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityInvalidData()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            string ItemQuantity = "This is not a number";

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryTimeMin()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string DeliveryTime = TestDate.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryTimeMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string DeliveryTime = TestDate.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryTimeMid()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddMonths(1);

            string DeliveryTime = TestDate.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryTimeMax()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddMonths(2);

            string DeliveryTime = TestDate.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryTimeMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddMonths(3);

            string DeliveryTime = TestDate.ToString();

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryTimeInvalidData()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            string DeliveryTime = "This is not a date! ";

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressExtMin()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            string DeliveryAddress = "";

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressExtMax()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            string DeliveryAddress = "";

            DeliveryAddress = DeliveryAddress.PadRight(150, 'a');

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            string DeliveryAddress = "";

            DeliveryAddress = DeliveryAddress.PadRight(19, 'a');

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            string DeliveryAddress = "";

            DeliveryAddress = DeliveryAddress.PadRight(21, 'a');

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMid()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            string DeliveryAddress = "";

            DeliveryAddress = DeliveryAddress.PadRight(25, 'a');

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxLesOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            string DeliveryAddress = "";

            DeliveryAddress = DeliveryAddress.PadRight(29, 'a');

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxplusOne()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            string DeliveryAddress = "";

            DeliveryAddress = DeliveryAddress.PadRight(31, 'a');

            Error = AnOrder.Valid(PhoneNumber, ItemQuantity, DeliveryTime, DeliveryAddress);

            Assert.AreNotEqual(Error, "");
        }

    }
}
