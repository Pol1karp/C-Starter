using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitStar1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(2, 3)); 
        }
        static double Pow(double baseNum, int exponent)
        {
            return Math.Pow(baseNum, exponent);
        }
    }
}
