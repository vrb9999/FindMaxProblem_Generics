using System;

namespace IntMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values of integers x, y and z:");
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            int z = Convert.ToInt16(Console.ReadLine());
            max_int usingInt = new max_int();
            int result = usingInt.Maximum(x, y, z);
            Console.WriteLine("The Maximum of three integers is :" + result);
        }
    }
}
