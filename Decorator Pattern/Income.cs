using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Pattern
{
    public class Income : IMortgage
    {
        private readonly IMortgage _mortgage;
        public string ProductName { get; set; }
        public int Rate { get; set; }
        public int Amount { get; set; }

        public Income(IMortgage mortgage)
        {
            _mortgage = mortgage ?? throw new ArgumentNullException(nameof(mortgage));
        }
        public int GetMortgage()
        {
            var result = _mortgage.GetMortgage() - (Amount * Rate);
            Console.WriteLine(string.Format("{0}: -{1}", ProductName, Amount*Rate));
            return result;
        }
    }

}
