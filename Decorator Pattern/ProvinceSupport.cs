
namespace Software_Design_Pattern
{
    public class ProvinceSupport : IMortgage
    {
        private readonly IMortgage _mortgage;
        public string ProductName { get; set; }
        public int Amount { get; set; }

        public ProvinceSupport(IMortgage mortgage)
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
