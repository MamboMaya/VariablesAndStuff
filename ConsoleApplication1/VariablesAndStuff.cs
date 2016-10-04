using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class VariablesAndStuff
    {
        static void Main(string[] args)
        {
            string yo = "Hello World.";
            int year = 1492;
            bool pet = false;
            DateTime date = DateTime.Now;
            decimal myMoney = 5.45m;
            char letter = 'X';

            Console.WriteLine(yo);
            Console.ReadLine();
            Console.WriteLine("Columbus sailed the world in " + year + ".");
            Console.ReadLine();
            Console.WriteLine("It is " + pet + " that I have a dog at home.");
            Console.ReadLine();
            Console.WriteLine("Today is " + date + ".");
            Console.ReadLine();
            Console.WriteLine("I spent {0:C2} on a cheeseburger.", myMoney);
            Console.ReadLine();
            Console.WriteLine(letter + " marks the spot.");
            Console.ReadLine();

        }
    }
}
