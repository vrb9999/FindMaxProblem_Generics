using System;
using System.Collections.Generic;
using System.Text;

namespace Extend_Parameters
{
    public class FindMaximum<T> where T : IComparable
    {
        private T[] values;
        public FindMaximum(T[] values)
        {
            this.values = values;
        }
        private T[] SortValues(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T FindMaxValue()
        {
            T[] sortedValues = SortValues(values);
            return sortedValues[sortedValues.Length - 1];
        }
    }
}
