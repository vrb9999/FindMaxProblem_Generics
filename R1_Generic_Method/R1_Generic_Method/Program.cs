using System;

namespace R1_Generic_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int Mvalue1 = GenericMethod<int>.MaxusingGenerics<int>(2, 3, 4);
            Console.WriteLine("The Maximum of three integers is :" + Mvalue1);
            double Mvalue2 = GenericMethod<double>.MaxusingGenerics<double>(2.2, 3.3, 4.4);
            Console.WriteLine("The Maximum of three values is :" + Mvalue2);
            string Mvalue3 = GenericMethod<string>.MaxusingGenerics<string>("Apple", "peach", "banana");
            Console.WriteLine("The Maximum of three strings is :" + Mvalue3);
        }
    }
}
