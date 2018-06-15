using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStringIdCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minion ID Generator");
            Console.WriteLine("Enter any number");

            // Read Line
            int inputAsNumber = 0, whole;
            string stringId;
            string primeString = "";
            for (int l = 0; l <= 1993; l++)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out inputAsNumber) == true && inputAsNumber > 0 && inputAsNumber <= 1000)
                {
                    Console.WriteLine("You entered a valid number: {0}", inputAsNumber);
                    break;
                }
                else
                {
                    Console.WriteLine("You didn't enter a number! Please enter a valid number.");
                }
            }

            for (double i = 2; i <= 1993; i++)
            {
                whole = 0;
                for (double j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        whole++;
                    }
                }
                if (whole == 0)
                {
                    primeString = primeString + i;
                }
            }

            int userInput = Convert.ToInt32(inputAsNumber);
            //Console.WriteLine(primeString);
            userInput--;
            stringId = primeString.Substring(userInput, 5);

            Console.WriteLine("Your ID number is: {0}", stringId);
            Console.ReadKey();
        }
    }
}