using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_2
{
    public static class Extension
    {
        public static string Concat(this string a,string b )
        {
            return a + b;
        }

    }
}
