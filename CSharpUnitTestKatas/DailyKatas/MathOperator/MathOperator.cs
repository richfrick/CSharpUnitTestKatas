namespace CSharpUnitTestKatas.DailyKatas.MathOperator;

public class MathOperator
{
    //if a square return area, if rectangle return perimeter
    public static int AreaOrPerimeter(int l, int w) {
        return l == w? l * w : (l + w)*2;  
  
    }
    
    //Take a time in seconds (timer not 24hr time) and return it in HH:MM:SS up to a maximum of 99:24:24
    public static string TimeStamp(int timeInSecs)
    {
        try
        {
            var time = timeInSecs;
            if (time > 359999) time = 359999;
            int hours = time / 3600;
            int mins = (time % 3600) / 60;
            int secs = time % 60;

            return $"{hours:D2}:{mins:D2}:{secs:D2}";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    //Check if a score is > the average sum of an array
    public static bool BetterThanAverage(int[] classPoints, int yourPoints)
    {
        return yourPoints > classPoints.Aggregate(0, (sum, x) => sum + x) / classPoints.Length;
    }
    
}