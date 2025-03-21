using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Pattern
{
    public class Downpayment : IMortgage
    {
        private readonly IMortgage _mortgage;
        public string ProductName { get; set; }
        public int Amount { get; set; }

        public Downpayment(IMortgage mortgage)
        {
            _mortgage = mortgage ?? throw new ArgumentNullException(nameof(mortgage));
        }
        public int GetMortgage()
        {
            var result = _mortgage.GetMortgage() - Amount;
            Console.WriteLine(string.Format("{0}: -{1}", ProductName, Amount));
            return result;
        }
    }

}
