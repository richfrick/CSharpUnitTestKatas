namespace CSharpUnitTestKatas.DailyKatas.MathOperator;

public class Probability
{
    public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
    {
        var remainingBlue = blueStart - bluePulled;
        var remainingRed = redStart - redPulled;

        return (double)remainingBlue / (remainingBlue + remainingRed);
    }
}