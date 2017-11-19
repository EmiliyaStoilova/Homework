using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int radius = random.Next(33, 187);
            Console.WriteLine("The circle random height is = {0}", radius);
            double area = radius * radius * Math.PI;
            Console.WriteLine("The circle area is = {0:1.##}", area);
        }
    }
}
