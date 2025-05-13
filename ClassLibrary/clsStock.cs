using System;
using System.Collections.Generic;
using System.Linq;
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

        public decimal  GamePrice
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
        public bool Find(int gameId)
        {
            //set the private data members to the test data value 
            mGameId = 5;
            //always return true
            return true;
        }
        /*
        public bool Find(String gameTitle)
        {
            //set the private data members to the test data value 
            mGameTitle = "Elden Ring";
           //always return true
           return true;
        }

        public bool Find(DateTime gameReleaseDate)
        {
           //set the private data members to test data value 
           mGameReleaseDate = Convert.ToDateTime("22/02/2022");
            //always return true 
            return true;
        }

        public bool Find(decimal gamePrice)
        {
            //set the private data members to test data value 
            mGamePrice = 55.99m;
            //always return true 
            return true;
        }

        public bool Find(int stockQty)
        {
            //set the private data members to test data value 
            mStockQty = 22;
            //always return true 
            return true;
        }

        public bool Find(int gameRating)
        {
            //set the private data members to test data value
            mGamingRating = 9;
            //always return true
            return true;
        }
        */
    }
}
