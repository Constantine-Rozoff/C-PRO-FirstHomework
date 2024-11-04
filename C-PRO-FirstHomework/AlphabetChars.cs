namespace C_PRO_FirstHomework;

internal class AlphabetChars
{
    public static void GetLetterRowNumberAndChangeCase(char[] alphabet, char letter)
    {
        Console.WriteLine("Selected letter is: " + letter);

        int letterPosition = Array.IndexOf(alphabet, letter);
        Console.WriteLine("Letter position in alphabet is: " + (Array.IndexOf(alphabet, letter) + 1));
        
        string a = alphabet[letterPosition].ToString();
        
        if (a.All(char.IsUpper))
        {
            a = a.ToLower();
        }
        else
        {
            a = a.ToUpper();
        }
        
        alphabet[letterPosition] = char.Parse(a);
        
        Console.WriteLine("{0}", string.Join(", ", alphabet));
    }
}
