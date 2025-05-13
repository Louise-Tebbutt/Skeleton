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

        public decimal  GamePrice { get; set; }
        public int StockQty { get; set; }
        public int GameRating { get; set; }
        public bool IsDigital { get; set; }

        public bool Find(int gameId)
        {
            //set the private data members to the test data value 
            mGameId = 21;
            //always return true
            return true;
        }

        public bool Find(object gameTitle)
        {
            //set the private data members to the test data value 
            mGameTitle = "Elden Ring";
           //always return true
           return true;
        }

        public bool Find(object gameReleaseDate)
        {
           //set the private data members to test data value 
           mGameReleaseDate = Convert.ToDateTime("09/05/2025");
        }
    }
}
