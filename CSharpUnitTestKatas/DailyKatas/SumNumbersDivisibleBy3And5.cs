namespace CSharpUnitTestKatas;

public class SumNumbersDivisibleBy3And5
{
    public static int Solution(int value)
    {
        var sum = 0;
        for (int i = 1; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}