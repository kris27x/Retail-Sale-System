using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data for Valid
        string itemDescription = " mongoose bike";
        string itemQuantity = Convert.ToString(32);
        string dateAdded = DateTime.Now.Date.ToString();
        string price = Convert.ToString(3.0);

        public bool Found { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //v00egd00001l.lec-admin.dmu.ac.uk
            //p2559549 
            //Imat1113
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Available = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStock.Available, TestData);
        }

        [TestMethod]
        public void ItemNoPropertyOK()
        {

            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ItemNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemNo, TestData);

        }

        [TestMethod]
        public void ItemDescriptionPropertyOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnStock.ItemDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemDescription, TestData);
        }

        [TestMethod]
        public void ItemQuantityOK()

        {

            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.ItemQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ItemQuantity, TestData);

        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);

        }
        [TestMethod]
        public void PricePropertyOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            double TestData = 6.9;
            //assign the data to the property
            AnStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Price, TestData);

        }
        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ItemNo = 2;
            //invoke the method
            Found = AnStock.Find(ItemNo);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestItemNoFound()
        {
            //create an instance of the class we want to create
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(lets assume)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemNo = 2;
            //invoke the method
            Found = AnItem.Find(ItemNo);
            //check the Item no
            if (AnItem.ItemNo != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (lets say it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemNo = 2;
            //invoke the method
            Found = AnItem.Find(ItemNo);
            //check the property
            if (AnItem.DateAdded != Convert.ToDateTime("16/12/2008 "))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemDescriptiopnFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 2;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemDescription != "Mongoose Bike ")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemQuantityFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 2;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemQuantity != 52)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(lets assume)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemNo = 2;
            //invoke the method
            Found = AnItem.Find(ItemNo);
            //check the Price
            if (AnItem.Price != 1500)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AnItem = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(lets assume)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemNo = 2;
            //invoke the method
            Found = AnItem.Find(ItemNo);
            //check the Availibilty
            if (AnItem.Available != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AnItem = new clsStock();
            //string variable to store any error message
            String error = "";
            //invoke the method
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price );
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void ItemDescriptionMinLessOne()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            itemDescription = "";
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, ""); //using NotEqual because we want to see that there is an error
        }

        [TestMethod]
        public void ItemDescriptionMinBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            itemDescription = "";
            itemDescription = itemDescription.PadRight(1, 'a');
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemDescriptionMinPlusOne()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            itemDescription = "";
            itemDescription = itemDescription.PadRight(2, 'a');
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemDescriptionMaxLessOneBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            itemDescription = "";
            itemDescription = itemDescription.PadRight(199, 'a');
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemDescriptionMaxBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            itemDescription = "";
            itemDescription = itemDescription.PadRight(200, 'a');
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemDescriptionMaxPlusOneBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            itemDescription = "";
            itemDescription = itemDescription.PadRight(201, 'a');
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemDescriptionMidBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            itemDescription = "";
            itemDescription = itemDescription.PadRight(100, 'a');
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemDescriptionExtremMaxBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            itemDescription = "";
            itemDescription = itemDescription.PadRight(250, 'a');
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AnItem = new clsStock();
            String error = "";

            double aPrice = 38.99;

            price = aPrice.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PriceMinBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";

            double aPrice = 39.99;

            price = aPrice.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceMinPlusOneBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";

            double aPrice = 40.99;

            price = aPrice.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceMaxBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";

            double aPrice = 200000.00;

            price = aPrice.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceMaxJustBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";

            double aPrice = 200000.99;

            price = aPrice.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOneBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";

            double aPrice = 200001.00;

            price = aPrice.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PriceMidBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";

            double aPrice = 100000.00;

            price = aPrice.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PriceExtremeMaxBoundary()
        {
            clsStock AnItem = new clsStock();
            String error = "";

            double aPrice = 10000000.00;

            price = aPrice.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PriceInvalidDataType()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            String name = "Joe";

            price = name;

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            //- 100 years
            testDate = testDate.AddYears(-100);
            string dateAdded = testDate.ToString();
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(-1);
            string dateAdded = testDate.ToString();
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            string dateAdded = testDate.ToString();
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(1);
            string dateAdded = testDate.ToString();
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            // 10 years
            testDate = testDate.AddYears(10);
            string dateAdded = testDate.ToString();
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            string dateAdded = "this is not a date!";
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void ItemQuantityMinLessOne()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            Int32 TestItem;
            TestItem = 0;
            itemQuantity = TestItem.ToString();
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxPlusOne()
        {
            clsStock AnItem = new clsStock();
            String error = "";
            Int32 TestItem;
            TestItem = 17;
            itemQuantity = TestItem.ToString();
            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxLessOne()
        {
            clsStock AnItem = new clsStock();

            String error = "";

            Int32 TestItem;

            TestItem = 4999;

            itemQuantity = TestItem.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemQuantityMinBoundary()
        {
            clsStock AnItem = new clsStock();

            String error = "";

            Int32 TestItem;

            TestItem = 1;

            itemQuantity = TestItem.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemQuantityMinPlusOne()
        {
            clsStock AnItem = new clsStock();

            String error = "";

            Int32 TestItem;

            TestItem = 2;

            itemQuantity = TestItem.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemQuantityMinLessOneItem()
        {
            clsStock AnItem = new clsStock();

            String error = "";

            Int32 TestItem;

            TestItem = 0;

            itemQuantity = TestItem.ToString();

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ItemQuantityInvalidData()
        {
            clsStock AnItem = new clsStock();

            String error = "";

            itemQuantity = "This is not a number";

            error = AnItem.Valid(itemDescription, itemQuantity, dateAdded, price);

            Assert.AreNotEqual(error, "");
        }

    }
}