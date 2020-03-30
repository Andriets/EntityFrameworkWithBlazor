using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class ProductType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
