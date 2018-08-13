using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number, i'll tell you if its odd or even: ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
                Console.WriteLine("the number you gave me was even");
            else
                Console.WriteLine("the number you gave was odd");

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
