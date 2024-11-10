namespace C_PRO_FirstHomework;

public class StringFilter
{
    public static void FilterString(string text, string[] prohibitedItems)
    {
        string[] stringAsWordArray = text.Split(" ");

        for (int i = 0; i < stringAsWordArray.Length; i++)
        {
            if(Array.Exists(prohibitedItems, element => element.ToLower() == stringAsWordArray[i].ToLower()))
            {
                stringAsWordArray[i] = "***";
            }
        }
        
        Console.WriteLine(string.Join(" ", stringAsWordArray));
    }
}