using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        public object AllStocks { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }
        /*[TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.ItemNo = 9;
            TestItem.ItemDescription = " Some description ";
            TestItem.ItemQuantity = 3;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Price = 3;
            TestItem.Available = true;

            AllStock.StockList = TestList;

            //Assert.AreEqual(AllStocks.StockList, TestList);
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestStock = new clsStock();

            TestStock.ItemNo = 8;
            TestStock.ItemDescription = " Some description ";
            TestStock.ItemQuantity = 3;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 3;
            TestStock.Available = true;
            AllStocks.ThisStock = TestStock;
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }*/
    }
}
