namespace CSharpUnitTestKatas.DailyKatas;

public class RomanConvert
{
    private static readonly Dictionary<int, string> Map = new()
    {
        {1000, "M"},
        {900, "CM"},
        {500, "D"},
        {400, "CD"},
        {100, "C"},
        {90, "XC"},
        {50, "L"},
        {40, "XL"},
        {10, "X"},
        {9, "IX"},
        {5, "V"},
        {4, "IV"},
        {1, "I"}
    };

    public static string ToRoman(int number)
    {
        var result = "";

        foreach (var kvp in Map)
        {
            while (number >= kvp.Key)
            {
                result += kvp.Value;
                number -= kvp.Key;
            }
        }

        return result;
    }
}