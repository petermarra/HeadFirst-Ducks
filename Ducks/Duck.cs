using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ducks
{
    class Duck: IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;
        
        public int CompareTo(Duck ducktoCompare)
        {
            if (this.Size > ducktoCompare.Size)
                return -1;
            else if (this.Size < ducktoCompare.Size)
                return 1;
            else
                return 0;
        }
        public override string ToString()
        {
            return $"A {Size} inch {Kind.ToString()}";
        }
    }
}
