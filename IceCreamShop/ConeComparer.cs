using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public ConeComparer()
        {
        }

        public int Compare(Cone x, Cone y)
        {
            //original attempt below, I discovered I actually needed to return 1, 0, or -1
            //not just any number
            //int result = (int)(x.Cost - y.Cost);
            //return result;

            if (x.Cost > y.Cost) return 1;
            else if (x.Cost == y.Cost) return 0;
            else return -1;
        }
    }
}
