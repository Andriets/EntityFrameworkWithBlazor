using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; } 
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
