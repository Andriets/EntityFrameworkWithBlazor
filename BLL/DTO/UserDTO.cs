﻿using ClassLibrary1;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class UserDTO 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
