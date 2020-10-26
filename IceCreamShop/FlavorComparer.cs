using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public FlavorComparer()
        {
        }

        //original compare based on name
        //public int Compare(Flavor x, Flavor y)
        //{
        //    return string.Compare(x.Name, y.Name);
        //}

        //new compare based on flavor allergens
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count > y.Allergens.Count) return 1;
            if (x.Allergens.Count == y.Allergens.Count) return 0;
            return -1;
        }
    }
}
