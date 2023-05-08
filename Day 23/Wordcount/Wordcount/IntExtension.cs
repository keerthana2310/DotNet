using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wordcount
{
    public static class IntExtension
    {
          public static int WordCount(this string s)
        {
            return s.Split(' ').Length;
        }

    }
}
