﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Owner_Parameters
{
    public class PagingParameters
    {
        const int maxPageSize = 10;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 2;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
