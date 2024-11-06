using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_buzz_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 0; i <= 15; i++) //0-14-1-15
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;
                {
                    //9 % 3 = 0
                    if ((i % 3 == 0 && i % 5 == 0) 
                        {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");

                    }


                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");

                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                } }
        }
    }
}
