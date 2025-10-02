namespace CSharpUnitTestKatas.DailyKatas;
using System.Collections.Generic;
public class BeginnerKatas
{
    public static string ShortenToDate(string longDate)
    {
        return longDate.Split(',')[0];
    }

    public static bool SpeakEnglish(string sentence)
    {
        return sentence.ToLower().Contains("english");
    }
    
    public static int AreaOrPerimeter(int l, int w) {
        return l == w? l * w : (l + w)*2;  
  
    }
    
    public static object[] RemoveEveryOther(object[] arr)
    {
        var newArr = new List<object>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                newArr.Add(arr[i]);  
            } 
        }

        return newArr.ToArray();
    }
    
    public static object[] RemoveEveryOtherRefactor(object[] arr)
    {
        return arr.Where((element, index) => index % 2 == 0).ToArray();
    }
    
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var uniqueIntCount =  numbers.GroupBy(a => a)
            .Select(x => new { key = x.Key, val = x.Count() });

        var uniqueInt =  uniqueIntCount.Where(x => x.val == 1)
            .Select(x => x.key)
            .FirstOrDefault();

        return uniqueInt;
    }
    
    public static int GetUniqueRefactor(IEnumerable<int> numbers)
    {
        return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
    }

    public static string TimeStamp(int timeInSecs)
    {
        try
        {
            var time = timeInSecs;
            if (timeInSecs > 359999) timeInSecs = 359999;
            int hours = timeInSecs / 3600;
            int mins = (timeInSecs % 3600) / 60;
            int secs = timeInSecs % 60;

            return $"{hours:D2}:{mins:D2}:{secs:D2}";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
 
    }
    
}