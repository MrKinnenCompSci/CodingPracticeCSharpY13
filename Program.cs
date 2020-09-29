using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeCSharpY13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coding practice for C# learning the programming basics
            double circleArea;
            circleArea = CalculateCircleArea();
            Console.WriteLine($"The area of the circle is: {circleArea}");
            Console.WriteLine($"The area of the circle is: {Math.Round(circleArea,3)}");
            Console.ReadLine();
        }

        static double CalculateCircleArea()
        {
            double circleArea;
            int radius;
            const double VALUE_OF_PI = 3.14;
            

            Console.WriteLine("What is the radius of the circle?");
            radius = Int32.Parse(Console.ReadLine());

            //circleArea = VALUE_OF_PI * radius * radius;
            circleArea = Math.PI * Math.Pow(radius, 2);


            return circleArea;
        }
    }
}
