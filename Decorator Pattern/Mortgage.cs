using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Software_Design_Pattern
{
    public class Mortgage : IMortgage
    {
        public int Amount { get; set; }

        public int GetMortgage()
        {
            Console.WriteLine("Target Mortgage: " + Amount);
            return Amount;
        }
    }
}
