namespace C_PRO_FirstHomework;

public class StringSplitter
{
    public static string[]  SplitLine(string line, string symbol)
    {
        int position;
        int count = 0;
        string[] splittedString = new string[3];
        do
        {
            position = line.IndexOf(symbol, StringComparison.Ordinal);

            if (position >= 0)
            {
                string city = line.Substring(0, position);

                splittedString[count] = city;
                count++;
            
                line = line.Substring(position + 2);
            }
            else
            {
                splittedString[count] = line;
            }
        } while (position > 0);
        
        return splittedString;
    }
}