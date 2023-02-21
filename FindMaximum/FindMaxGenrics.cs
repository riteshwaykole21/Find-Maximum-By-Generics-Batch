using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    // IComparible is used to provide default sort order of Your Object
    public class FindMaxGenrics<T> where T : IComparable
    {
        public T FindMaxValue ( T first ,T second, T third)
        {

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            else if (second.CompareTo(third) > 0 && second.CompareTo(first) > 0)
                 return second;
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                 return third;

            return first;
        }
    }
}
