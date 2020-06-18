using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class ProductView
    {
        public int id { get; set; }
        public string productName { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public byte[] image { get; set; }
        public int productTypeId { get; set; }
    }
}
