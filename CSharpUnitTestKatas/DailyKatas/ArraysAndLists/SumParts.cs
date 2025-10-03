using Microsoft.EntityFrameworkCore.Query;

namespace CSharpUnitTestKatas.DailyKatas.ArraysAndLists;

public class SumParts
{
    public static int[] PartsSums(int[] ls)
    {
        var total = ls.Sum();
        var partsSumList = new List<int>(){total}; 
        
        for(var i = 0; i < ls.Length; i++)
        {
            total -= ls[i];
            partsSumList.Add(total);
        }
        
        return partsSumList.ToArray();
    }
}