using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg369Exercise
{
    class Duck : Bird, IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck other)
        {
            if (Size > other.Size)
            {
                return 1;
            }
            if (Size < other.Size)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"A {Size}\" {Kind}";
        }
    }
}
