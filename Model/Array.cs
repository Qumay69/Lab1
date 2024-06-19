using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public abstract class Array
    {
        protected List<int> elements;

        public Array(IEnumerable<int> elements)
        {
            this.elements = elements.ToList();
        }

        public abstract void Add(Array other);
        public abstract void Foreach();

        public List<int> Elements => elements;
    }

}
