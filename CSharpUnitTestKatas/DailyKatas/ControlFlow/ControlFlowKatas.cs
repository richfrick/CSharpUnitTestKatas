namespace CSharpUnitTestKatas.DailyKatas.ControlFlow;

public class ControlFlowKatas
{
    public static char Grader(double score)
    {
        switch(score)
        {
            case > 1 or < 0.6:
                return 'F';
            case >= 0.9:
                return 'A';
            case >= 0.8:
                return 'B';
            case >= 0.7:
                return 'C';
            case >= 0.6:
                return 'D';
        }
        return '\0';
    }
}