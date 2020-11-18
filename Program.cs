using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder= a % b;
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            Console.WriteLine("What is the radius of your circle?");
            var r = double.Parse(Console.ReadLine());
            
            double pi = 3.14159;
            double AreaOfCircle = (pi * (r * r));       

            Console.WriteLine($"The area of a circle with radius of {r} is {AreaOfCircle}");
        }
    }
}
