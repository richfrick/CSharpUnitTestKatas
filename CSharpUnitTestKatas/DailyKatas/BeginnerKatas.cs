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
    
    public static bool BetterThanAverage(int[] classPoints, int yourPoints)
    {
        return yourPoints > classPoints.Aggregate(0, (sum, x) => sum + x) / classPoints.Length;
    }
    
    public static bool ValidateHello(string greetings)
    {
        Dictionary<string, string> language = new()
        {
            {"Hello", "english" },
            {"Ciao", "italian"},
            {"Salut", "french"},
            {"Hallo", "german"},
            {"Hola", "spanish"},
            {"Ahoj", "czech Republic"},
            {"Czesc", "polish"}
        };
        
        foreach (var key in language.Keys)
        {
            if (greetings.ToLower().Contains(key.ToLower()))
            {
                return true;
            }
        }
        return false;
    }
    public static bool ValidateHelloRefactor(string greetings)
    {
        var hellos = new string[] { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc"};
        return hellos.Any(x => greetings.ToLower().Contains(x));
    }
    
    public static long[] Digitizer(long n)
    {
        return n.ToString().Select(x => Convert.ToInt64(x - '0')).Reverse().ToArray();
    }

    public static string Array(string s)
    {
        var splitString = s.Split(',');
        return splitString.Length > 2 ? string.Join(" ", splitString[1..^1]) : null;
    }
    
}