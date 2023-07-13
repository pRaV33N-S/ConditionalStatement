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
            Console.WriteLine("Enter the pre mark");
            int pre = int.Parse(Console.ReadLine());
            if (pre > 60)
            {
                Console.WriteLine("Enter the final mark");
                int final = int.Parse(Console.ReadLine());
                if(final>55)
                    Console.WriteLine("Selected");
                else
                    Console.WriteLine("Fail in Final");
            }
            else
            {
                Console.WriteLine("Fail in Pre");
            }
        }
    }
}
