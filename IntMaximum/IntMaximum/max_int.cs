using System;
using System.Collections.Generic;
using System.Text;

namespace IntMaximum
{
    public class max_int
    {
        public int Maximum(int x, int y, int z)
        {
            if (x.CompareTo(y) > 0 && x.CompareTo(z) > 0 ||
                x.CompareTo(y) >= 0 && x.CompareTo(z) > 0 ||
                x.CompareTo(y) > 0 && x.CompareTo(z) >= 0)
            {
                return x;
            }
            if (y.CompareTo(x) > 0 && y.CompareTo(z) > 0 ||
                y.CompareTo(x) >= 0 && y.CompareTo(z) > 0 ||
                y.CompareTo(x) > 0 && y.CompareTo(z) >= 0)
            {
                return y;
            }
            if (z.CompareTo(x) > 0 && z.CompareTo(y) > 0 ||
                z.CompareTo(x) >= 0 && z.CompareTo(y) > 0 ||
                z.CompareTo(x) > 0 && z.CompareTo(y) >= 0)
            {
                return z;
            }
            throw new Exception("Either two or three inputs are same");
        }
    }
}
