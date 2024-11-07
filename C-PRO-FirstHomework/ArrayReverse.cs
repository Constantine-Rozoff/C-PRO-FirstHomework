namespace C_PRO_FirstHomework;

public class ArrayReverse
{
    public static int[] ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }
        
        return arr;
    }
}