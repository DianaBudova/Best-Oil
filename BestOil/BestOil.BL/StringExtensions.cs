namespace BestOil.BL
{
    public static class StringExtensions
    {
        public static string ToUpperFirstChar(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}