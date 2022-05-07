using System;
using System.Collections.Generic;
using System.Text;

namespace FloatMaximum
{
    public class max_float
    {
        public double Maximumfloat(double a, double b, double c)
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
