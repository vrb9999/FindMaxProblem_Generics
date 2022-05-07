using System;

namespace StringMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values of Strings first, second and third String");
            string firstString = Convert.ToString(Console.ReadLine());
            string secondString = Convert.ToString(Console.ReadLine());
            string thirdString = Convert.ToString(Console.ReadLine());
            max_string usingStrings = new max_string();
            string result = usingStrings.Maximum(firstString, secondString, thirdString);
            Console.WriteLine("The Maximum of three strings is :" + result);
        }
    }
}
