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
            integerfindmax integerfindmax1 = new integerfindmax();
            integerfindmax1.FindMaxValue(10, 30, 40);
            Console.ReadLine();
        }
    }
}
