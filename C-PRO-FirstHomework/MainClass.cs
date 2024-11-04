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
        int number = 313;
        NumberReader.Reader(number);
        
        //Task 5
        int a = 5;
        int b = 2;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = " + a + ", " + "b = " + b);
    }
}