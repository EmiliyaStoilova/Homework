using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int average;
                int number = 0;
                int counter = 0;

                do
                {
                    Console.WriteLine("Enter a number");
                    number = int.Parse(Console.ReadLine());

                    if (number>=1 && counter <=255)
                    {
                        if (number % 2 == 0)
                        {
                            counter++;
                            a = a + number;
                        }
                    }
                    else if (number<0)
                    {
                        Console.WriteLine("The number must be between 1 and 255");
                        break;
                    }

                }

                while (number != 0);
                {
                    average = a / counter;
                    Console.WriteLine("The rezult is " + average);
                }
            }
            catch
            {
                Console.WriteLine("Number between 1 and 255!");
            }
        }
    }
}
