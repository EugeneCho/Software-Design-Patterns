using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Pattern.Composite_Pattern
{
    public class Restaurant : DishComposite
    {
        public Restaurant(string name) : base(name) { }

        public override string Type => "Restaurant";
        
    }
    
}
