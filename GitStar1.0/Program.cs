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

            Console.WriteLine(Pow(5, 2));
            int a = 10;
            string m = "Привет, Git!";
            Console.WriteLine(Cube(5)); 
        }
        static double Pow(double baseNum, int exponent)
        {
            return Math.Pow(baseNum, exponent);

        }
        static int Cube(int num)
        {
            return num * num * num;
        }
    }
}
