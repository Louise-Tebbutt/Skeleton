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
            {
                // create a string variable to store any error messages
                String Error = "";
                //create a temporary variable to store the date values
                DateTime DateTemp;
                //if the GameId Is blank
                if (gameTitle.Length == 0)
                {
                    //record the error 
                    Error = Error + "The Game Title may not be blank :";
                }


                // if the game title is greater than 6 characters
                if (gameTitle.Length > 6)
                {
                    //record the error 
                    Error = Error + "The Game Title must be less than 6 characters :";
                }


                // if the Game Title is greater than 100 characters
                if (gameTitle.Length > 100)
                {
                    // record the error 
                    Error = Error + "The Game Title must be less than 100 characters : ";
                }

                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(gameReleaseDate);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the past:";
                }

                //check to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the future:";
                }

                // return any error messages
                return Error;
            }
        }

    }
}
