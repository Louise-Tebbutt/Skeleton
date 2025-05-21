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

    }
}