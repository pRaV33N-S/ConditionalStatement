using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int pre = int.Parse(Console.ReadLine());
            if (pre > 60)
            { 
                Console.WriteLine("Selected");
            }
            else
            {
                Console.WriteLine("Fail in Pre");
            }


        }
    }
}
