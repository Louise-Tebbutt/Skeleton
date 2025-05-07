using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsStock
    {
        public int GameId  { get; set; }
        public string GameTitle { get; set; }
        public DateTime GameReleaseDate { get; set; }
        public decimal  GamePrice { get; set; }
        public int StockQty { get; set; }
        public int GameRating { get; set; }
        public bool IsDigital { get; set; }


    }
}
