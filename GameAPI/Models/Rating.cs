using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameAPI.Models
{
    public class Rating
    {
        public int GameId { get; set; }
        public int Number { get; set; }

        public Rating(int gameId, int number)
        {
            GameId = gameId;
            Number = number;
        }
    }
}