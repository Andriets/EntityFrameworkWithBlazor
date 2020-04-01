using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class ProductType : BaseEntity
    {
        public string TypeName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
