using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Windows;
using System.Xml.Linq;

namespace Lab1.Model
{
    public class XorArray : Array
    {
        public XorArray(IEnumerable<int> elements) : base(elements) { }

        public override void Add(Array other)
        {
            if (other is XorArray otherXorArray)
            {
                var maxLength = Math.Max(elements.Count, otherXorArray.elements.Count);
                var extendedElements = elements.Concat(Enumerable.Repeat(0, maxLength - elements.Count)).ToList();
                var extendedOtherElements = otherXorArray.elements.Concat(Enumerable.Repeat(0, maxLength - otherXorArray.elements.Count)).ToList();

                elements = extendedElements.Zip(extendedOtherElements, (a, b) => a ^ b).ToList();
            }
        }

        public override void Foreach()
        {
            elements = elements.Select(e => (int)Math.Sqrt(e)).ToList();
        }
    }
}

