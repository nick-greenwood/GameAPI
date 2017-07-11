using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameAPI.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public int AgeRating { get; set; }

        public Game(int id, string name, int yearOfRelease, int ageRating)
        {
            Id = id;
            Name = name;
            YearOfRelease = yearOfRelease;
            AgeRating = ageRating;
        }
    }
}