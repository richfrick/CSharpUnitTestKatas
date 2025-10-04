namespace CSharpUnitTestKatas.DailyKatas.ArraysAndLists;

public class ArraysLists
{
    //create new array that contains the values from odd index only (Long Way)
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
    
    //create new array that contains the values from odd index only (Short Way using Linq)
    public static object[] RemoveEveryOtherRefactor(object[] arr)
    {
        return arr.Where((element, index) => index % 2 == 0).ToArray();
    }
    
    
    // if there is a unique value in an array return it (Long way)
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var uniqueIntCount =  numbers.GroupBy(a => a)
            .Select(x => new { key = x.Key, val = x.Count() });

        var uniqueInt =  uniqueIntCount.Where(x => x.val == 1)
            .Select(x => x.key)
            .FirstOrDefault();

        return uniqueInt;
    }
    
    // if there is a unique value in an array return it (Short way using Linq)
    public static int GetUniqueRefactor(IEnumerable<int> numbers)
    {
        return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
    }
    
    // Covert a string to an array and return in the reverse order
    public static long[] Digitizer(long n)
    {
        return n.ToString().Select(x => Convert.ToInt64(x - '0')).Reverse().ToArray();
    }
    
    //remove the first and last elements in a string and return minus the commas
    public static string Array(string s)
    {
        var splitString = s.Split(',');
        return (splitString.Length > 2 ? string.Join(" ", splitString[1..^1]) : null);
    }
    
    //returns the count of true values 
    public static int CountTrueValues(bool[] boolValues)
    {
        return boolValues.Count(x => x);
    }
    
}