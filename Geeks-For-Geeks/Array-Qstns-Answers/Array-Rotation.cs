// Program for array rotation
/*
 * Input arr[] = [1, 2, 3, 4, 5, 6, 7], d = 2, n =7
1) Store the first d elements in a temp array
   temp[] = [1, 2]
2) Shift rest of the arr[]
   arr[] = [3, 4, 5, 6, 7, 6, 7]
3) Store back the d elements
   arr[] = [3, 4, 5, 6, 7, 1, 2]
*/
using System;
class ArrayRotation
{
	public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int rotateBy = 2;
        LeftRotate(arr, rotateBy)
    }
    private static void LeftRotate(int[] arr, int rotateBy)
    {
        int size = arr.Length;
        
        for(int i = 0; i < rotateBy; i++)
        {
            RotateByOne(arr, size);
        }
    }
    private static void RotateByOne(int[] arr, int size)
    {
        int tmp = arr[0];

        for(int i = 0; i < size - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[size - 1] = tmp;
    }
}
