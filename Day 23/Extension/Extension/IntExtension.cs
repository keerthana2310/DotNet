﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class IntExtension
    {
        public static bool isLessthan( this int i, int j)
        {
            return i < j;
        }
       
    }
}
