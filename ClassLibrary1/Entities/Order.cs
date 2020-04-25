using ClassLibrary1.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Order : BaseEntity
    {
        public int CountOfProduct { get; set; }
        public double OrderSum { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
