﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class OrderDTO
    {
        public int CountOfProduct { get; set; }
        public double OrderSum { get; set; }
        public int UserId { get; set; }
    }
}
