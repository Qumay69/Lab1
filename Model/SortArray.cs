using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public class SortArray : Array
    {
        public SortArray(IEnumerable<int> elements) : base(elements) { }

        public override void Add(Array other)
        {
            if (other is SortArray otherSortArray)
            {
                elements = elements.Union(otherSortArray.elements).ToList();
            }
        }

        public override void Foreach()
        {
            elements.Sort();
        }
    }
}
