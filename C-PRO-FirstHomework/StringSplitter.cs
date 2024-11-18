using BenchmarkDotNet.Attributes;

namespace C_PRO_FirstHomework;

public class StringSplitter
{
    [Benchmark]
    public static string[]  SplitLine(string line, string symbol)
    {
        int position;
        int count = 0;
        int separatorCount = line.Count(c => c == ',');
        string[] splittedStringArray = new string[separatorCount + 1];
        
        do
        {
            position = line.IndexOf(symbol, StringComparison.Ordinal);

            if (position >= 0)
            {
                string city = line.Substring(0, position);

                splittedStringArray[count] = city;
                count++;
            
                line = line.Substring(position + 2);
            }
            else
            {
                splittedStringArray[count] = line;
            }
        } while (position > 0);
        
        return splittedStringArray;
    }
}