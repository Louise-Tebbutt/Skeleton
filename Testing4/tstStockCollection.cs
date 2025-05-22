using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of the class we want to create 
            ClsStockCollection AllStock = new ClsStockCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //Ccreate an instance of the class we want to create 
            ClsStockCollection AllStock = new ClsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClsStock> TestList = new List<ClsStock>();
            //Add an Item to the List 
            //Create the item of test data 
            ClsStock TestItem = new ClsStock();
            //set its properties
            TestItem.IsDigital = true;
            TestItem.GameId = 22;
            TestItem.GameTitle = "Urvarshi";
            TestItem.GameReleaseDate = DateTime.Now;
            TestItem.GamePrice = 10000000000000000.00m;
            TestItem.StockQty = 50;
            TestItem.GameRating = 9;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        
        [TestMethod]
        public void ThisStockPropertyOk()
        {
            //create an instance of the class we want to create 
            ClsStockCollection AllStock = new ClsStockCollection();
            //create some data to assign to the property
            ClsStock TestStock = new ClsStock();
            //set the properties of the test object
            TestStock.IsDigital = true;
            TestStock.GameId = 22;
            TestStock.GameTitle = "Urvarshi";
            TestStock.GameReleaseDate = DateTime.Now;
            TestStock.GamePrice = 10000000000000000.00m;
            TestStock.StockQty = 50;
            TestStock.GameRating = 9;
            //assign the data to the property 
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            ClsStockCollection AllStock = new ClsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClsStock> TestList = new List<ClsStock>();
            //Add an Item to the List 
            //Create the item of test data 
            ClsStock TestItem = new ClsStock();
            //set its properties
            TestItem.IsDigital = true;
            TestItem.GameId = 22;
            TestItem.GameTitle = "Urvarshi";
            TestItem.GameReleaseDate = DateTime.Now;
            TestItem.GamePrice = 10000000000000000.00m;
            TestItem.StockQty = 50;
            TestItem.GameRating = 9;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

    }
}
