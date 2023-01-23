namespace BestOil.BL
{
    static public class FoodPriceRatio
    {
        static public string[] food = { "Hot dog", "Hamburger", "French fries", "Soda" };
        static public Dictionary<string, double> foodPrice = new()
        {
            { food[0], 24.99 },
            { food[1], 34.99 },
            { food[2], 29.99 },
            { food[3], 19.99 },
        };
    }
}