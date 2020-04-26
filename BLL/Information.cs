using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Information
    {
        public bool Success { get; set; } 
        public string Message { get; set; } 

        public Information()
        {
            Success = true;
            Message = "";
        }
    }
}
