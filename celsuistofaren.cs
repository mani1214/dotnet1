using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsiustofarehnheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((celsius * 9 / 5) + 32);
            Console.ReadLine();
        }
    }
}
