namespace CSharpUnitTestKatas.DailyKatas.Numbers;

public class IsPrimeNumber
{
    
    public static bool isPrimeNumberSolution(int num)
    {
        if(num % 2 == 0 || num > 1)
        {
            var counter = 0;
            for (var i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                }
            }

            return counter <= 1;
        }
        else
        {
            return false;
        }
    }
    
    public static bool isPrimeNumberSolutionRefactor(int num)
    {
        if (num == 0) return false;
        if (num == 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        
        var boundary = (int)Math.Floor(Math.Sqrt(num));
        
            for (var i = 3; i <= boundary; i+=2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
        
        return true;
    }
}