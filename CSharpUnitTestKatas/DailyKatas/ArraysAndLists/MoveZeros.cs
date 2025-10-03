namespace CSharpUnitTestKatas.DailyKatas.ArraysAndLists;

public class MoveZeros
{
    
    //Using Linq
    public static int[] MoveZerosSolutionRefactor(int[] arr)
    {
        return arr.OrderBy(x => x == 0).ToArray();
    }
    
    // Using a loop
    public static int[] MoveZerosSolution(int[] arr)
    {
        var newArr = new List<int>();

        for (int i = arr.Length; i > 0; i--)
        {
            if(arr[i-1] == 0)
            {
                newArr.Add(arr[i-1]);
            }
            else
            {
                newArr.Insert(0, arr[i-1]);
            }

        }
        
        return newArr.ToArray();
    }
    
}