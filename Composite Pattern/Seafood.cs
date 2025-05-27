using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Pattern.Composite_Pattern
{
    public class Seafood : DishComposite
    {
        public Seafood(string name) : base(name) { }

        public override int Count => this.children.Sum(child => child.Count);
    }
}
