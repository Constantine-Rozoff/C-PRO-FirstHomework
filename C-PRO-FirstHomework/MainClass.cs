namespace C_PRO_FirstHomework;

public class MainClass
{
    public static void Main(string[] args)
    {
        //Task 1
        char[] alphabet =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
            'x', 'y', 'z'
        };

        char selectedLetter = 'm';
        
        AlphabetChars.GetLetterRowNumberAndChangeCase(alphabet, selectedLetter);
        
        
        //Task 2
        string cities = "London, Paris, Rome";
        string symbol = ",";

        string[] splittedCities = StringSplitter.SplitLine(cities, symbol);

        foreach (var city in splittedCities)
        {
            Console.WriteLine(city);
        }
        
        //Task 3
        string mainString = "London, Paris, Rome";
        string subString = "Rome";

        bool doesMainStringContainSubString = StringContains.IsContainString(mainString, subString);
        Console.WriteLine(doesMainStringContainSubString);
        
        //Task 4
        int number = 303;
        NumberReader.Reader(number);

        // Console.WriteLine(number % 100); // tens
        // Console.WriteLine(number % 10); // units
        // Console.WriteLine(number % 1);
        // Console.WriteLine(number / 100); // Hundreds
        // Console.WriteLine(number / 10);
        // Console.WriteLine(number / 1);
    }
}