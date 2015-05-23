using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write out a standard welcome message.
            Console.WriteLine("Welcome to Josh's FizzBuzz Generator v42!\n");

            // Let's initialize the loop limit.
            int loopStop = 100;

            // Time to get the loop started!
            for (int i = 1; i <= loopStop; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else
                {
                    Console.Write("{0} ", i);
                }
            }

            // Pause the console.
            Console.ReadLine();
        }
    }
}
