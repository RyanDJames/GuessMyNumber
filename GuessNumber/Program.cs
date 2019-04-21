using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int pick = 0;
            Random random = new Random();
            int number = random.Next(1, 100);
            Console.WriteLine("Pick between 1 and 100");
            int i = 0;
            while(pick != number)
            {
                try
                {
                    pick = Convert.ToInt32(Console.ReadLine());

                    if (pick > number)
                    {
                        Console.WriteLine("Your pick is too high");
                    }
                    else
                    {
                        Console.WriteLine("Your pick is too low");

                    }
                }
                catch
                {
                    Console.WriteLine("Your choice has to be an interger");
                }

                i++;
            }
            Console.WriteLine("Thats right! You needed " + i + " Chances to guess the right number");
            
        }
    }
}
