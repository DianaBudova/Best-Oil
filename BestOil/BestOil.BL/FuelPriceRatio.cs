namespace BestOil.BL
{
    static public class FuelPriceRatio
    {
        static public string[] fuel = { "A-95+", "A-95", "A-92", "Diesel", "Gas" };
        static public Dictionary<string, double> fuelPrice = new()
        {
            { fuel[0], 54.49 },
            { fuel[1], 52.19 },
            { fuel[2], 49.99 },
            { fuel[3], 53.79 },
            { fuel[4], 29.99 },
        };
    }
}