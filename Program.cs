using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd_Number_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if ( num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
