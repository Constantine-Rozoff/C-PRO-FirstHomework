namespace C_PRO_FirstHomework;

public class ArrayWithSkippedElement
{
    public static int[] GetRandomNumberArray(int count, int maxValue)
    {
        int minValue = 0;
        Random random = new Random();
        HashSet<int> uniqueNumbers = new HashSet<int>();

        while (uniqueNumbers.Count < count)
        {
            int randomNumber = random.Next(minValue, maxValue + 1);
            uniqueNumbers.Add(randomNumber);
        }

        int[] result = new int[uniqueNumbers.Count];
        uniqueNumbers.CopyTo(result);

        return result;
    }

    public static void RemoveRandomArrayElement(int[] numbers)
    {
        Random random = new Random();
        int indexToRemove = random.Next(0, numbers.Length);
        numbers[indexToRemove] = -1;
    }
    
    public static int HoleSeeker(int[] numbers)
    {
        int holeIndex = 0;
        foreach (var item in numbers)
        {
            if (item < 0)
            {
                holeIndex = Array.IndexOf(numbers, item);
            }
        }

        return holeIndex;
    }
}