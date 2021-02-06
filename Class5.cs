using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revnumber
{
    class Class5
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int count = 0;
            while (start <= num)
            {
                if (num % start == 0)
                {
                    count++;
                }
                start++;
            }
            if(count==2)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not a prime");
            }
        }
    }
}
