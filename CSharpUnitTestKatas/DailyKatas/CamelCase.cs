using System.Text.RegularExpressions;
using static System.Array;

namespace CSharpUnitTestKatas;

public class CamelCase
{
    public string BreakCamelCase(string camelString)
    {
        string[] upperCaseWords = Regex.Split(camelString, "(?=[A-Z])");
        return string.Join(" ", upperCaseWords);
    }
}