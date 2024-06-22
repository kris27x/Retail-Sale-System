using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing4
{
    /// <summary>
    /// Summary description for tstOrderCollection
    /// </summary>
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //test to see it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 8;
            TestItem.PhoneNumber = 465967544567;
            TestItem.ItemQuantity = 3;
            TestItem.DeliveryTime = DateTime.Now.Date;
            TestItem.Delivery = true;
            TestItem.DeliveryAddress = "1 des vegas";
            TestItem.Notes = "leave at the door";

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestOrder = new clsOrder();

            TestOrder.OrderID = 8;
            TestOrder.PhoneNumber = 465967544567;
            TestOrder.ItemQuantity = 3;
            TestOrder.DeliveryTime = DateTime.Now.Date;
            TestOrder.Delivery = true;
            TestOrder.DeliveryAddress = "1 des vegas";
            TestOrder.Notes = "leave at the door";

            AllOrders.ThisOrder = TestOrder;

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.OrderID = 8;
            TestItem.PhoneNumber = 465967544567;
            TestItem.ItemQuantity = 3;
            TestItem.DeliveryTime = DateTime.Now.Date;
            TestItem.Delivery = true;
            TestItem.DeliveryAddress = "1 des vegas";
            TestItem.Notes = "leave at the door";

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.DeliveryTime = DateTime.Now.Date;
            TestItem.DeliveryAddress = "23 vermalen street ";
            TestItem.Delivery = true;
            TestItem.ItemQuantity = 2;
            TestItem.PhoneNumber = 67876543456;
            TestItem.Notes = "to be delivered at xxx address, around x time";
            //set this address to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of a class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.DeliveryTime = DateTime.Now.Date;
            TestItem.DeliveryAddress = "23 vermalen street ";
            TestItem.Delivery = true;
            TestItem.ItemQuantity = 2;
            TestItem.PhoneNumber = 67876543456;
            TestItem.Notes = "to be delivered at xxx address, around x time";
            //set thisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key to the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.DeliveryTime = DateTime.Now.Date;
            TestItem.DeliveryAddress = "2 city CTI ";
            TestItem.Delivery = false;
            TestItem.ItemQuantity = 1;
            TestItem.PhoneNumber = 77894543456;
            TestItem.Notes = "let's get you a new address";
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see this order matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of a class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.DeliveryTime = DateTime.Now.Date;
            TestItem.DeliveryAddress = "23 vermalen street ";
            TestItem.Delivery = true;
            TestItem.ItemQuantity = 2;
            TestItem.PhoneNumber = 67876543456;
            TestItem.Notes = "to be delivered at xxx address, around x time";
            //set thisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            TestItem.OrderID = PrimaryKey;
            //set the primary key of the test data
            AllOrders.ThisOrder.Find(PrimaryKey);
            //find the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that th erecord was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDeliveryAddressOK()
        {
            //create an instance of a class containing unfiltered result
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance o fthe filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByDeliveryAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDeliveryAddressNotFound()
        {
            //create an instance of a filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply an address that does not exist
            FilteredOrders.ReportByDeliveryAddress("xxx XXXXXXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDeliveryAddressTestDataFound()
        {
            //create an instance of a filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply an address that does not exist
            FilteredOrders.ReportByDeliveryAddress("23 RTY CTI");
            //check that the correct number of the records are found
            if(FilteredOrders.Count == 2)
            {
                //check that the first record is 8
                if(FilteredOrders.OrderList[0].OrderID != 8)
                {
                    OK = false;
                }
                //check that the second recor is 9
                if (FilteredOrders.OrderList[1].OrderID != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsTrue(OK);
        }
    }
}
