namespace CSharpUnitTestKatas.DailyKatas;

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
    
}