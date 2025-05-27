using System.Text.Json;


namespace Software_Design_Pattern.Composite_Pattern
{
    public class RestaurantFactory : IRestaurantFactory
    {
        public RestaurantFactory(string name) 
        {
            Console.WriteLine(JsonSerializer.Serialize(Create(name)));
        }

        public Restaurant Create(string name)
        {
            var restaurant = new Restaurant(name);
            restaurant.Add(CreateMenu());

            return restaurant;
        }
    
        private IComponent CreateMenu()
        {
            // Create a seafood dish composite
            var seafood = new Seafood("Seafood");
            
            // Create a robster then add roberster dishes
            var lobsters = new Lobster("Lobster");
            lobsters.Add(new Dish("NY Lobster Roll"));
            lobsters.Add(new Dish("NY Lobster Burger"));
            lobsters.Add(new Dish("Robster Pasta"));

            var shrimps = new Shrimp("Shrimp");
            shrimps.Add(new Dish("Shrimp Salad"));
            shrimps.Add(new Dish("Shrimp Pizza"));
            shrimps.Add(new Dish("Shrimp Pasta"));

            // Add seafood dishes to the seafood
            seafood.Add(lobsters);
            seafood.Add(shrimps);

            return seafood;
        }
    }
}
