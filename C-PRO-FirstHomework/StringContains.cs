namespace C_PRO_FirstHomework;

public class StringContains
{
    public static bool ContainsSubstring(string mainString, string subString)
    {
            if (subString.Length == 0) return true; 
            if (mainString.Length < subString.Length) return false; 

            for (int i = 0; i <= mainString.Length - subString.Length; i++)
            {
                bool found = true;

                for (int j = 0; j < subString.Length; j++)
                {
                    if (mainString[i + j] != subString[j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found) return true;
            }

            return false;
    }
}