using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void InstanceOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.Stock = "1";
            TestItem.Price = 200;
            TestItem.SupplierFeedback = 5;
            TestItem.SupplierProduct = "orange Bike";
            TestItem.SupplierId = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);

        
        
            

        }
        [TestMethod]
        public void ThisSuppliersPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.Stock = "1";
            TestSupplier.Price = 200;
            TestSupplier.DeliveryDate = DateTime.Now.Date;
            TestSupplier.SupplierFeedback = 5;
            TestSupplier.SupplierProduct = "orange Bike";
            TestSupplier.SupplierId = 1;
            AllSuppliers.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);


        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.Stock = "1";
            TestItem.SupplierId = 1;
            TestItem.Price = 200;
            TestItem.SupplierFeedback = 5;
            TestItem.SupplierProduct = "orange Bike";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOk()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.Stock = "1";
            TestItem.Price = 200;
            TestItem.SupplierFeedback = 3;
            TestItem.SupplierId = 1;
            TestItem.SupplierProduct = "orange Bike";
            TestItem.DeliveryDate = DateTime.Now.Date;
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.SupplierId = PrimaryKey;
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);


        }



    }
}


