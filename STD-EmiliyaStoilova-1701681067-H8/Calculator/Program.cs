using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {          
            string answer = string.Empty;

            do
            {
                Console.WriteLine("Do you want to calculate some numbers? (yes or no)");
                answer = Console.ReadLine();
            }
            
            while (answer == "no");

            if (answer == "yes")
            {
                Console.WriteLine("Enter first number");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter operation (+, -, *, /)");
                char operation = char.Parse(Console.ReadLine());

                if (operation == '+')
                {
                    double rezult = (number1 + number2) * 0.1 + number1 + number2;
                    Console.WriteLine("Rezult is: {0:0.00}", rezult);
                }

                if (operation == '-')
                {
                    if (number1 > number2)
                    {
                        int rezult = number1 * number1 - number2;
                        Console.WriteLine("Rezult is: {0:0.00}", rezult);
                    }
                    else
                    {
                        int rezult = number2 * number2 - number1;
                        Console.WriteLine("Rezult is: {0:0.00}", rezult);
                    }
                }

                if (operation == '*')
                {
                    double rezult = Math.Sqrt(number1) * number2;
                    Console.WriteLine("Rezult is: {0:0.00}", rezult);
                }

                if (operation == '/')
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error!!! You can't divide to 0!");
                    }
                    else
                    {
                        double rezult = number1 / number2;
                        Console.WriteLine("Rezult is: {0:0.00}", rezult);
                    }

                }
            }
        }
    }
}
