namespace CSharpUnitTestKatas;

public class FindTargetInArray
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        for (var i = 0; i<numbers.Length; i++)
        {
            for (var j = i+1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i, j };
                }
            }

        }
        
        return new int[0];
    }
}