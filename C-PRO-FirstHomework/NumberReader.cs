namespace C_PRO_FirstHomework;

public class NumberReader
{
    public static void Reader(int number)
    {
        string result1 = "";
        string result2 = "";
        string result3 = "";
        
        switch (number / 100)
        {
            case <= 0:
                result1 = "";
                break;

            case 1:
                result1 = "One hundred";
                break;

            case 2:
                result1 = "Two hundred";
                break;

            case 3:
                result1 = "Three hundred";
                break;

            case 4:
                result1 = "Four hundred";
                break;

            case 5:
                result1 = "Five hundred";
                break;

            case 6:
                result1 = "Six hundred";
                break;

            case 7:
                result1 = "Seven hundred";
                break;

            case 8:
                result1 = "Eight hundred";
                break;

            case 9:
                result1 = "Nine hundred";
                break;

            default:
                Console.WriteLine("Invalid value");
                break;
        }
        
        switch (number % 100)
        {
            case <= 0:
                result2 = "";
                break;
            
            case <10:
                result2 = "";
                break;

            case 10:
                result2 = "Ten";
                break;
            
            case 11:
                result2 = "Eleven";
                break;

            case 12:
                result2 = "Twenty";
                break;

            case 13:
                result2 = "Thirteen";
                break;

            case 14:
                result2 = "Fourteen";
                break;

            case 15:
                result2 = "Fifteen";
                break;

            case 16:
                result2 = "Sixteen";
                break;

            case 17:
                result2 = "Seventeen";
                break;

            case 18:
                result2 = "Eighteen";
                break;

            case 19:
                result2 = "Nineteen";
                break;
            
            case 20:
                result2 = "Twenty";
                break;
            
            case <30:
                result2 = "Twenty";
                break;
            
            case <40:
                result2 = "Thirty";
                break;
            
            case <50:
                result2 = "Forty";
                break;
            
            case <60:
                result2 = "Fifty";
                break;
            
            case <70:
                result2 = "Sixty";
                break;
            
            case <80:
                result2 = "Seventy";
                break;
            
            case <90:
                result2 = "Eighty";
                break;
            
            case <100:
                result2 = "Ninety";
                break;

            default:
                Console.WriteLine("Invalid value");
                break;
        }

        if ((number % 100) < 10 || (number % 100) >= 20)
        {
            switch (number % 10)
            {
                case <= 0:
                    result3 = "";
                    break;

                case 1:
                    result3 = "One";
                    break;

                case 2:
                    result3 = "Two";
                    break;

                case 3:
                    result3 = "Three";
                    break;

                case 4:
                    result3 = "Four";
                    break;

                case 5:
                    result3 = "Five";
                    break;

                case 6:
                    result3 = "Six";
                    break;

                case 7:
                    result3 = "Seven";
                    break;

                case 8:
                    result3 = "Eight";
                    break;

                case 9:
                    result3 = "Nine";
                    break;

                default:
                    Console.WriteLine("Invalid value");
                    break;
            }
        }
        
        Console.WriteLine($"{result1} " + $"{result2} " + $"{result3}");
    }
}