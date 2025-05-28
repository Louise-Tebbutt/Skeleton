using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ClsStockCollection
    {
        //private data member for the list
        List<ClsStock> mStockList = new List<ClsStock>();
        //private member data for ThisStock
        ClsStock mThisStock = new ClsStock();


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

        public ClsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }
        
        //constructor for the class 
        public ClsStockCollection()
        {
            //variable for the index 
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock 
                ClsStock AStock = new ClsStock();
                //read in the fields for the current records 
                AStock.GameId = Convert.ToInt32(DB.DataTable.Rows[Index]["GameId"]);
                AStock.GameTitle = Convert.ToString(DB.DataTable.Rows[Index]["GameTitle"]);
                AStock.GameReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["GameReleaseDate"]);
                AStock.GamePrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["GamePrice"]);
                AStock.StockQty = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQty"]);
                AStock.GameRating = Convert.ToInt32(DB.DataTable.Rows[Index]["GameRating"]);
                AStock.IsDigital = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsDigital"]);
                //add the record to the private data member 
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            // Adds a record to the database based on the values of ThisStock
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@GameTitle", mThisStock.GameTitle);
            DB.AddParameter("@GameReleaseDate", mThisStock.GameReleaseDate);
            DB.AddParameter("@GamePrice", mThisStock.GamePrice);
            DB.AddParameter("@StockQty", mThisStock.StockQty);
            DB.AddParameter("@GameRating", mThisStock.GameRating);
            DB.AddParameter("@IsDigital", mThisStock.IsDigital);

            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {  
           // update an existing record based on the values of ThisStock
           // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the new stored procedure
            DB.AddParameter("@GameId", mThisStock.GameId);
            DB.AddParameter("@GameTitle", mThisStock.GameTitle);
            DB.AddParameter("@GameReleaseDate", mThisStock.GameReleaseDate);
            DB.AddParameter("@GamePrice", mThisStock.GamePrice);
            DB.AddParameter("@StockQty", mThisStock.StockQty);
            DB.AddParameter("@GameRating", mThisStock.GameRating);
            DB.AddParameter("@IsDigital", mThisStock.IsDigital);

            // execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@GameId", mThisStock.GameId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }
    }
}