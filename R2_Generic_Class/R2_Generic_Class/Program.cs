using System;

namespace R2_Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass genericClass = new GenericClass();
            int value1 = GenericClass.MaxusingGenerics<int>(2, 3, 4);
            Console.WriteLine("The Maximum of three integers is :" + value1);
            double value2 = GenericClass.MaxusingGenerics<double>(2.2, 3.3, 4.4);
            Console.WriteLine("The Maximum of three values is :" + value2);
            string value3 = GenericClass.MaxusingGenerics<string>("Apple", "peach", "banana");
            Console.WriteLine("The Maximum of three strings is :" + value3);
        }
    }
}
