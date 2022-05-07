using System;

namespace FloatMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values of floats a, b and c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            max_float usingFloat = new max_float();
            double result = usingFloat.Maximumfloat(a, b, c);
            Console.WriteLine("The Maximum of three floats is :" + result);
        }
    }
}
