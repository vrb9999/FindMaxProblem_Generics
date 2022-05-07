using System;
using System.Collections.Generic;
using System.Text;

namespace PrintMaxValue
{
    public class FindMaximum<T> where T : IComparable
    {
        public T[] array;
        public FindMaximum(T[] array)
        {
            this.array = array;
        }
        public T[] Sort()
        {
            Array.Sort(array);
            return array;
        }
        public T FindMaxValue()
        {
            T[] sorted = this.Sort();
            return sorted[sorted.Length - 1];
        }
        public void PrintMaxValue()
        {
            Console.WriteLine(this.FindMaxValue());
        }
    }
}
