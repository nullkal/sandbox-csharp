using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var answer = rnd.Next(1, 100);

            Console.WriteLine("=== The Guessing Game ===");
            Console.WriteLine("");
            Console.WriteLine("The hidden number is between 1 to 100, guess it!");
            Console.WriteLine("");

            while(true)
            {
                Console.Write("number (0=exit)? ");

                try
                {
                    var guess = int.Parse(Console.ReadLine());
                    if (guess == 0)
                    {
                        break;
                    }

                    if (guess == answer)
                    {
                        Console.WriteLine("That's it! Congratulations!");
                        break;
                    }
                    else if (guess < answer)
                    {
                        Console.WriteLine("The answer is larger. Try again.");
                    } else if (answer < guess)
                    {
                        Console.WriteLine("The answer is smaller. Try again.");
                    } else
                    {
                        Debug.Fail("This line should be unreachable.");
                    }
                } catch(FormatException) {}
            }
        }
    }
}
