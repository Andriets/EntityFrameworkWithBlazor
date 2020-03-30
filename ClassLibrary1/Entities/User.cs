using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class User 
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
