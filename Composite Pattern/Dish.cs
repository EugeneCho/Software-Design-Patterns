using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Pattern.Composite_Pattern
{
    public class Dish : IComponent
    {
        public Dish(string name) {
            Name = name; 
        }
        public string Name { get; }

        public string Type => "Dish";

        public int Count { get; } = 1;
    }
}
