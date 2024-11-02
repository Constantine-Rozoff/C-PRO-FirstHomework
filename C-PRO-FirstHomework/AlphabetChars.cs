namespace MyNamespace;

internal class AlphabetChars
{
    public static void Main(string[] args)
    {
        char[] alphabet =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
            'x', 'y', 'z'
        };

        char selectedLetter = 'z';
        Console.WriteLine("Selected letter is: " + selectedLetter);

        int letterPosition = Array.IndexOf(alphabet, selectedLetter);
        Console.WriteLine("Letter position in alphabet is: " + (Array.IndexOf(alphabet, selectedLetter) + 1));
        
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
