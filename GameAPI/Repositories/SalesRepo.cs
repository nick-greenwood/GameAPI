using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameAPI.Models;

namespace GameAPI.Repositories
{
    public class SalesRepo
    {
        public List<Sale> GetAllSales()
        {
            return new List<Sale>
            {
                new Sale(1, 40, "Game"),
                new Sale(1, 30, "Asda"),
                new Sale(1, 40, "Amazon"),
                new Sale(1, 20, "Game"),
                new Sale(1, 20, "Amazon"),
                new Sale(1, 40, "Game"),

                new Sale(2, 40, "Game"),
                new Sale(2, 40, "Game"),
                new Sale(2, 20, "Amazon"),
                new Sale(2, 30, "Asda"),

                new Sale(3, 40, "Game"),
                new Sale(3, 20, "Amazon"),
                new Sale(3, 20, "Game"),
                new Sale(3, 40, "Amazon"),
                new Sale(3, 40, "Asda"),

                new Sale(4, 20, "Game"),
                new Sale(4, 30, "Amazon"),
                new Sale(4, 30, "Game"),

                new Sale(5, 40, "Game"),
                new Sale(5, 40, "Amazon"),
                new Sale(5, 40, "Game"),

                new Sale(6, 40, "Game"),
                new Sale(6, 40, "Asda"),
                new Sale(6, 30, "Asda"),
                new Sale(6, 40, "Game"),

                new Sale(7, 30, "Game"),
                new Sale(7, 20, "Game"),
                new Sale(7, 40, "Amazon"),
                new Sale(7, 30, "Asda"),
                new Sale(7, 30, "Game"),
                new Sale(7, 40, "Amazon"),

                new Sale(8, 40, "Amazon"),
                new Sale(8, 20, "Amazon"),
                new Sale(8, 60, "Game"),
                new Sale(8, 40, "Game"),

                new Sale(9, 30, "Amazon"),
                new Sale(9, 30, "Amazon"),
                new Sale(9, 20, "Amazon"),
                new Sale(9, 30, "Amazon"),
                new Sale(9, 40, "Game"),

                new Sale(10, 20, "Amazon"),
                new Sale(10, 20, "Game"),
                new Sale(10, 40, "Amazon"),
                new Sale(10, 40, "Game"),
                new Sale(10, 20, "Amazon"),
                new Sale(10, 40, "Game"),
            };
        }
    }
}