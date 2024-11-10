namespace C_PRO_FirstHomework;

public class SymbolGenerator
{
    public static string RandomSymbolGenerator(int numberOfSymbols)
    {
        Random random = new Random();

        string symbols = "!@#$%^&*()_+-=[]{}|;:,.<>?/~";
        string finalString = "";

        for (int i = 0; i < numberOfSymbols; i++)
        {
            char randomSymbol = symbols[random.Next(symbols.Length)];
            finalString += randomSymbol;
        }
        
        return finalString;
    }
}