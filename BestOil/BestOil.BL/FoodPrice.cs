namespace BestOil.BL
{
    public class FoodPrice
    {
        public double[] priceFood;

        public FoodPrice()
        {
            priceFood = new double[FoodPriceRatio.food.Length];
        }

        public double SetTotalPrice()
        {
            double result = 0;
            foreach (var food in priceFood)
                result += food;
            return Math.Round(result, 2);
        }
    }
}