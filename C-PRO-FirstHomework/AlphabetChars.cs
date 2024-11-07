namespace C_PRO_FirstHomework;

internal class AlphabetChars
{
    public static void GetLetterRowNumberAndChangeCase(char[] alphabet, char letter)
    {
        Console.WriteLine("Selected letter is: " + letter);

        int letterPosition = Array.IndexOf(alphabet, letter);
        Console.WriteLine("Letter position in alphabet is: " + (Array.IndexOf(alphabet, letter) + 1));
        
        if (char.IsUpper(alphabet[letterPosition]))
        {
            alphabet[letterPosition] = char.ToLower(alphabet[letterPosition]);
        }
        else
        {
            alphabet[letterPosition] = char.ToUpper(alphabet[letterPosition]);
        }
        
        Console.WriteLine("{0}", string.Join(", ", alphabet));
    }
}
