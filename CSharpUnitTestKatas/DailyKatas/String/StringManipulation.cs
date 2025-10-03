namespace CSharpUnitTestKatas.DailyKatas.String;

public class StringManipulation
{
    public static string ShortenToDate(string longDate)
    {
        return longDate.Split(',')[0];
    }
    
    public static bool SpeakEnglish(string sentence)
    {
        return sentence.ToLower().Contains("english");
    }
    
    //check if a string contains any element in an array
    public static bool ValidateHello(string greetings)
    {
        var hellos = new string[] { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc"};
        return hellos.Any(x => greetings.ToLower().Contains(x));
    }
    
}