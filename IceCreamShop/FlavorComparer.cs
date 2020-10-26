using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public FlavorComparer()
        {
        }

        public int Compare(Flavor x, Flavor y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
