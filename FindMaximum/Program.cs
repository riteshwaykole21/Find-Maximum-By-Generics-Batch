using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            IntegerFindMax integerfindmax1 = new IntegerFindMax();
            integerfindmax1.FindMaxValue(10, 30, 40);
            integerfindmax1.FindMaxValue(10.30f, 30.45f, 40.56f);
            Console.ReadLine();
        }
    }
}
