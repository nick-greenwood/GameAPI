using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameAPI.Models;

namespace GameAPI.Repositories
{
    public class GamesRepo
    {
        public List<Game> GetAllGames()
        {
            return new List<Game>
            {
                new Game(1, "Halo", 2001, 12),
                new Game(2, "Halo 2", 2004, 12),
                new Game(3, "Halo 3", 2007, 15),
                new Game(4, "Madden NFL 25", 2013, 9),
                new Game(5, "Destiny", 2014, 18),
                new Game(6, "Frogger", 1981, 3),
                new Game(7, "Paperboy 2", 1991, 12),
                new Game(8, "Tony Hawks Pro Skater", 2015, 15),
                new Game(9, "Fifa 2017", 2016, 3),
                new Game(10, "Knights of the Old Rebublic", 2013, 15),
            };
        }
    }
}
