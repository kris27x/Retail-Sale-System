using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
       
        string SupplierFeedback = "5";
        string SupplierProduct = "orange Bike";
        string Price = "200";
        string DeliveryDate = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void StockPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String TestData = "1";
            AnSupplier.Stock = TestData;
            Assert.AreEqual(AnSupplier.Stock, TestData);
        }

        [TestMethod]

        public void DeliveryDatePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.DeliveryDate = TestData;
            Assert.AreEqual(AnSupplier.DeliveryDate, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierId = TestData;
            Assert.AreEqual(AnSupplier.SupplierId, TestData);

        }

        [TestMethod]
        public void SupplierFeedbackPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 5;
            AnSupplier.SupplierFeedback = TestData;
            Assert.AreEqual(AnSupplier.SupplierFeedback, TestData);
        }

        [TestMethod]
        public void SupplierProductPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "orange Bike";
            AnSupplier.SupplierProduct = TestData;
            Assert.AreEqual(AnSupplier.SupplierProduct, TestData);

        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 200;
            AnSupplier.Price = TestData;
            Assert.AreEqual(AnSupplier.Price, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierIdFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierProduct != "orange Bike")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryDateFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.DeliveryDate != Convert.ToDateTime("05/05/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierFeedbackFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierFeedback != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.Price != 200)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMeMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct,Price,DeliveryDate);
        }
        [TestMethod]
        public void DeliveryDateExtremeMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DeliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DeliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DeliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(error, "");
        }
        [TestMethod]

        public void DeliveryDateExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DeliveryDate = TestDate.ToString();
            Error = AnSupplier.Valid(SupplierFeedback,SupplierProduct, Price, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateInvalidData()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string DeliveryDate = "This is not a date! : ";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierProductMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string SupplierProduct = "";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        public void SupplierProductMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string SupplierProduct = "a";
            Error = AnSupplier.Valid(SupplierProduct, SupplierFeedback, Price, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void SupplierProductMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "aa";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string Price = "";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string Price = "a";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string Price = "11111111";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");
        
        
        }
        [TestMethod]
        public void PriceMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string Price = "111111111";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierFeedbackMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string SupplierFeedback = "";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierFeedbackMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string SupplierFeedback = "a";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierFeedbackMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string SupplierFeedBack = "aa";
            Error = AnSupplier.Valid(SupplierFeedBack, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierFeedbackMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string SupplierFeedBack = "";
            SupplierFeedback = SupplierFeedBack.PadRight(49, '1');
            Error = AnSupplier.Valid(SupplierFeedBack, SupplierProduct, Price, DeliveryDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplierFeedbackMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string SupplierFeedback = "";
            SupplierFeedback = SupplierFeedback.PadRight(50, '1');
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierFeedbackMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string SupplierFeedback = "";
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierFeedbackMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string Error = "";
            string SupplierFeedback = "";
            SupplierFeedback = SupplierFeedback.PadRight(25, '1');
            Error = AnSupplier.Valid(SupplierFeedback, SupplierProduct, Price, DeliveryDate);
            Assert.AreEqual(Error, "");
        }









    }
}




    



        