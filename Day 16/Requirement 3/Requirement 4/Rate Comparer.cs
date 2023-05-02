using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_4
{
    internal class Rate_Comparer
    {
        public class RatingComparer : IComparer<Song>

        {

           public int Compare(Song x, Song y)

            {

                return y.Rating.CompareTo(x.Rating);

            }
        }
    }
}
