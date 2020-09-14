using System;
using System.ComponentModel.DataAnnotations;

namespace StockFollower.Models
{
    public class Stock
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }   
        public string Expiration_Date { get; set; }
        public string Bought_By { get; set; }
        public int in_Stock { get; set; }

    }



}