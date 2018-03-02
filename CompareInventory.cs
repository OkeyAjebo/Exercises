using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayExercise
{
    public class CompareInventory : IEqualityComparer<Inventory>
    {
        public bool Equals(Inventory x, Inventory y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(Inventory obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
