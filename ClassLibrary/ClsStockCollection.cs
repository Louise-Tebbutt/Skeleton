using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ClsStockCollection
    {
        //private data member for the list
        List<ClsStock> mStockList = new List<ClsStock>();
        //public property for the address list 

        public List<ClsStock> StockList
        {
            get
            {
                //return the private data 
                return mStockList;
            }
            set
            {
                //set the private data 
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list 
                return mStockList.Count;
            }
            set
            {
                //later losers !!!
            }
        }

        public ClsStock ThisStock { get; set; }
        
        //constructor for the class 
        public ClsStockCollection()
        {
            //create the items of test data 
            ClsStock TestItem = new ClsStock();
            //set its properties 
            TestItem.IsDigital = true;
            TestItem.GameId = 22;
            TestItem.GameTitle = "Urvarshi";
            TestItem.GameReleaseDate = DateTime.Now;
            TestItem.GamePrice = 10000000000000000.00m;
            TestItem.StockQty = 50;
            TestItem.GameRating = 9;
            //add the test item to the test list 
            mStockList.Add(TestItem);
            //re initialise the object for some new data
            TestItem.IsDigital = true;
            TestItem.GameId = 22;
            TestItem.GameTitle = "Urvarshi";
            TestItem.GameReleaseDate = DateTime.Now;
            TestItem.GamePrice = 10000000000000000.00m;
            TestItem.StockQty = 50;
            TestItem.GameRating = 9;
            //add the item to the test list 
            mStockList.Add(TestItem);
        }

    }
}