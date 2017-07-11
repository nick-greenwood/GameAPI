using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameAPI.Models
{
    public class Sale
    {
        public int GameId { get; set; }
        public decimal Price { get; set; }
        public string SoldBy { get; set; }

        public Sale(int gameId, decimal price, string soldBy)
        {
            GameId = gameId;
            Price = price;
            SoldBy = soldBy;
        }
    }
}