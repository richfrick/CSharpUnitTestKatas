namespace CSharpUnitTestKatas.DailyKatas.ArraysAndLists;

public class LineNumbering
{
    public static List<string> Number(List<string> lines)
    {
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i] = $"{i + 1}: {lines[i]}";
        }
        return lines;
    }
}