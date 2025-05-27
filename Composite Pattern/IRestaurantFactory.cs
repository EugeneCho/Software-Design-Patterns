using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Pattern.Composite_Pattern
{
    public interface IRestaurantFactory
    {
        Restaurant Create(string name);
    }
}
