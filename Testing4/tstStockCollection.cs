using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;


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
            TestItem.GameTitle = "TMNT";
            TestItem.GameReleaseDate = DateTime.Now;
            TestItem.GamePrice = 59.99m;
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
            TestStock.GameTitle = "TMNT";
            TestStock.GameReleaseDate = DateTime.Now;
            TestStock.GamePrice = 59.99m;
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
            TestItem.GameTitle = "TMNT";
            TestItem.GameReleaseDate = DateTime.Now;
            TestItem.GamePrice = 59.99m;
            TestItem.StockQty = 50;
            TestItem.GameRating = 9;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            ClsStockCollection AllStock = new ClsStockCollection();
            //create the item of test data
            ClsStock TestItem = new ClsStock();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsDigital = true;
            TestItem.GameId = 22;
            TestItem.GameTitle = "TMNT";
            TestItem.GameReleaseDate = DateTime.Now;
            TestItem.GamePrice = 59.99m;
            TestItem.StockQty = 50;
            TestItem.GameRating = 9;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.GameId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the collection class we want to test
            ClsStockCollection AllStock = new ClsStockCollection();

            //create the item of test data
            ClsStock TestItem = new ClsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set the properties of the test data
            TestItem.IsDigital = true;
            TestItem.GameTitle = "TMNT";
            TestItem.GameReleaseDate = DateTime.Now.Date;
            TestItem.GamePrice = 59.99m;
            TestItem.StockQty = 50;
            TestItem.GameRating = 9;

            //assign the test item to ThisStock
            AllStock.ThisStock = TestItem;

            //add the record and capture the primary key
            PrimaryKey = AllStock.Add();
            TestItem.GameId = PrimaryKey;

            //modify the test data
            TestItem.IsDigital = false;
            TestItem.GameTitle = "Horizon Zero Dawn";
            TestItem.GameReleaseDate = DateTime.Now;
            TestItem.GamePrice = 69.99m;
            TestItem.StockQty = 100;
            TestItem.GameRating = 10;

            //set ThisStock to the updated test item
            AllStock.ThisStock = TestItem;

            //call the update method
            AllStock.Update();

            //find the updated record
            AllStock.ThisStock.Find(PrimaryKey);

            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }



        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to create
            ClsStockCollection AllStock = new ClsStockCollection();

            // Create the item of test data
            ClsStock TestItem = new ClsStock();

            // Variable to store the primary key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.IsDigital = true;
            TestItem.GameTitle = "TMNT";
            TestItem.GameReleaseDate = DateTime.Now;
            TestItem.GamePrice = 59.99m;
            TestItem.StockQty = 50;
            TestItem.GameRating = 9;

            // Set ThisStock to the test data
            AllStock.ThisStock = TestItem;

            // Add the record and capture the primary key
            PrimaryKey = AllStock.Add();

            // Set the GameId of the test data to the newly generated primary key
            TestItem.GameId = PrimaryKey;

            // Find the record
            AllStock.ThisStock.Find(PrimaryKey);

            // Delete the record
            AllStock.Delete();

            // Try to find the record again
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            // Test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByGameTitleMethodOK()
        {
            // Create an instance of the class containing unfiltered results
            ClsStockCollection AllStock = new ClsStockCollection();

            // Create an instance of the filtered data
            ClsStockCollection FilteredStock = new ClsStockCollection();

            // Apply a blank string (should return all records)
            FilteredStock.ReportByGameTitle("");

            // Test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByGameTitleNoneFound()
        {
            // Create an instance of the class we want to create
            ClsStockCollection FilteredStock = new ClsStockCollection();

            // Apply a game title that doesn't exist
            FilteredStock.ReportByGameTitle("Nonexistent Game Title 123");

            // Test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByGameTitleTestDataFound()
        {
            // Create an instance of the filtered data
            ClsStockCollection FilteredStock = new ClsStockCollection();

            // Variable to store the outcome
            Boolean OK = true;

            // Apply a game title that is expected to return two records (set up in test DB)
            FilteredStock.ReportByGameTitle("yyy yyy");

            // Check that the correct number of records are found
            if (FilteredStock.Count == 2)
            {
                // Check to see that the first record's GameId is 25
                if (FilteredStock.StockList[0].GameId != 25)
                {
                    OK = false;
                }

                // Check to see that the second record's GameId is 26
                if (FilteredStock.StockList[1].GameId != 26)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            // Test to see that everything matched
            Assert.IsTrue(OK);
        }
    }
}   
