using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static string FizzBuzz(int n)
        {
            var sb = new StringBuilder();

            if (n % 3 == 0)
            {
                sb.Append("Fizz");
            }

            if (n % 5 == 0)
            {
                if (sb.Length != 0)
                {
                    sb.Append(" ");
                }

                sb.Append("Buzz");
            }

            string s = sb.ToString();
            if (s.Length == 0)
            {
                return n.ToString();
            } else
            {
                return s;
            }
        }

        static void Main(string[] args)
        {
            var fizzbuzz = Enumerable.Range(1, 500).Select(FizzBuzz);
            Console.WriteLine(String.Join(", ", fizzbuzz));

            Console.ReadKey();
        }
    }
}
