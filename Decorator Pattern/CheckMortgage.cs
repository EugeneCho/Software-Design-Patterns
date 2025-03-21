using Software_Design_Pattern;



// Singleton Class
public sealed class Client
{
    
    private static Client _instance;

    private static IMortgage _mortgage;
    
    public static Client GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Client();
        }
        return _instance;
    }

    public IMortgage GetMortgage() { return _mortgage; }
    public void SetMortgage(IMortgage mortgage) { _mortgage = mortgage; }
    public int GetMortgageAmount() { return _mortgage.GetMortgage(); }

}

public class CheckMortgage
{
    static void Main(string[] args)
    {
        // Create a new client profile
        Client client = Client.GetInstance();

        // Set target mortgage
        client.SetMortgage(new Mortgage() { Amount = 1000000 });
        Console.WriteLine("Remaining Mortgage: " + client.GetMortgageAmount());
        Console.WriteLine("-------------------------------------------------------");

        // Add Downpayment
        client.SetMortgage(new Downpayment(client.GetMortgage()) { ProductName="Downpayment", Amount = 400000 });
        Console.WriteLine("Remaining Mortgage: " + client.GetMortgageAmount());
        Console.WriteLine("-------------------------------------------------------");

        // Add Income
        client.SetMortgage(new Income(client.GetMortgage()) { ProductName = "Income", Amount = 100000, Rate = 5 });
        Console.WriteLine("Remaining Mortgage: " + client.GetMortgageAmount());
        Console.WriteLine("-------------------------------------------------------");

        // Add ProvinceSupport
        client.SetMortgage(new ProvinceSupport(client.GetMortgage()) { ProductName = "Province Support", Amount = 100000});
        Console.WriteLine("Remaining Mortgage: " + client.GetMortgageAmount());
        Console.WriteLine("-------------------------------------------------------");
        
    }
}

