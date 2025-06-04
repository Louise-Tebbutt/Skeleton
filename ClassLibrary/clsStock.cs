using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsStock
    {
        //private data member for the Game Id prorperty 
        private Int32 mGameId;

        //private data member for the Game Title property 
        private string mGameTitle;

        //private data member for the Game Release Date Property 
        private DateTime mGameReleaseDate;

        //private data member for the Game Price Property 
        private Decimal mGamePrice;

        //private data member for the StockQty property 
        private int mStockQty;

        //private data member for the GameRating Property 
        private int mGameRating;

        //private data member for the IsDigital Property 
        private bool mIsDigital;

        //gameId public property 

        public Int32 GameId
        {

            get
            {
                //this line of code sends data out of the property 
                return mGameId;
            }
            set
            {
                //this line of code allows data into the property 
                mGameId = value;
            }
        }

        //gametitle public property 
        public string GameTitle
        {
            get
            {
                //this line of code sends data out of the property 
                return mGameTitle;
            }
            set
            {
                //this line of code allows data into the property 
                mGameTitle = value;
            }
        }

        public DateTime GameReleaseDate
        {

            get
            {
                //this line of code seends data out of the property
                return (DateTime)mGameReleaseDate;
            }
            set
            {
                //this line of code allows data into the property
                mGameReleaseDate = value;
            }
        }

        public decimal GamePrice
        {
            get
            {
                //this line of code seends data out of the property
                return mGamePrice;
            }
            set
            {
                //this line of code allows data into the property
                mGamePrice = value;
            }
        }

        public int StockQty
        {
            get
            {
                //this line of the code sends data out of the property 
                return mStockQty;
            }
            set
            {
                //this line of code allows data into the property
                mStockQty = value;

            }
        }
        public int GameRating
        {
            get
            {
                //this line of the code sends data out of the property 
                return mGameRating;
            }
            set
            {
                //this line of code allows data into the property
                mGameRating = value;

            }
        }
        public bool IsDigital
        {
            get
            {
                //this line of the code sends data out of the property 
                return mIsDigital;
            }
            set
            {
                //this line of code allows data into the property
                mIsDigital = value;

            }
        }
        // Updated Find method with database connection
        public bool Find(int gameId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add the parameter for the stored procedure
            DB.AddParameter("@GameId", gameId);

            // Execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockId");

            // Check if one record was found
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mGameId = Convert.ToInt32(DB.DataTable.Rows[0]["GameId"]);
                mGameTitle = Convert.ToString(DB.DataTable.Rows[0]["GameTitle"]);
                mGameReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["GameReleaseDate"]);
                mGamePrice = Convert.ToDecimal(DB.DataTable.Rows[0]["GamePrice"]);
                mStockQty = Convert.ToInt32(DB.DataTable.Rows[0]["StockQty"]);
                mGameRating = Convert.ToInt32(DB.DataTable.Rows[0]["GameRating"]);
                mIsDigital = Convert.ToBoolean(DB.DataTable.Rows[0]["IsDigital"]);

                // Return true to indicate the record was found
                return true;
            }
            else
            {
                // Return false if no record was found
                return false;
            }
        }

        //function for the public validation method 

        public string Valid(string gameTitle, string gameReleaseDate, string gamePrice, string stockQty, string gameRating, string isDigital)
        {
            // create a string variable to store any error messages
            String Error = "";

            //GameTitle
            if (gameTitle.Length == 0)
            {
                // record the error 
                Error = Error + "The Game Title may not be blank :";
            }

            if (gameTitle.Length > 50)
            {
                Error = Error + "The Game Title must be less than or equal to 50 characters :";
            }


            //  GameReleaseDate 
            try
            {
                DateTime DateTemp = Convert.ToDateTime(gameReleaseDate);

                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "The release date cannot be more than 100 years ago :";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The release date cannot be in the future :";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date :";
            }

            //  GamePrice
            try
            {
                decimal PriceTemp = Convert.ToDecimal(gamePrice);

                if (PriceTemp <= 0)
                {
                    Error = Error + "The Game Price must be greater than 0 :";
                }
            }
            catch
            {
                Error = Error + "The Game Price was not a valid number :";
            }

            //StockQty
            try
            {
                int StockTemp = Convert.ToInt32(stockQty);

                if (StockTemp < 0)
                {
                    Error = Error + "The Stock Quantity cannot be negative :";
                }

                if (StockTemp > 10000)
                {
                    Error = Error + "The Stock Quantity cannot be more than 10,000 :";
                }
            }
            catch
            {
                Error = Error + "The Stock Quantity was not a valid number :";
            }

            //GameRating  
            try
            {
                int RatingTemp = Convert.ToInt32(gameRating);

                if (RatingTemp < 1 || RatingTemp > 10)
                {
                    Error = Error + "The Game Rating must be between 1 and 10 inclusive :";
                }
            }
            catch
            {
                Error = Error + "The Game Rating was not a valid number :";
            }

            // return any error messages
            return Error;
        }


    }
}
