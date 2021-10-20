using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerwork5_try2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a side of a square: ");
            int Side = Convert.ToInt32(Console.ReadLine());
            int Area = Side * Side;
            Console.WriteLine($"Area of square side {Side} is {Area}");
            Console.ReadKey();
        }
    }
}
