using System;
using System.Collections.Generic;
using System.Text;

namespace R1_Generic_Method
{
    public class GenericMethod<T> where T : IComparable
    {
        public T a, b, c;
        public GenericMethod(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static T MaxusingGenerics<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 ||
                a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 ||
                a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                return a;
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 ||
                b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 ||
                b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 ||
                c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 ||
                c.CompareTo(a) > 0 && c.CompareTo(b) >= 0)
            {
                return c;
            }
            throw new Exception("Either two or three inputs are same");
        }
    }
}
