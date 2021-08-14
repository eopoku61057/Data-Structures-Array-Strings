// Reversal algorithm for array rotation
private static void leftRotate(int[] arr, int d)
{
    if (d == 0)
    {
        return;
    }
    int size = arr.Length;
    d = d % size;
    ReverseArray(arr, 0, d - 1);
    ReverseArray(arr, d, size - 1);
    ReverseArray(arr, 0, size - 1);
}
private static void ReverseArray(int[] arr, int start, int end)
{
    while(start < end)
    {
        int tmp = arr[start];
        arr[start] = arr[end];
        arr[end] = tmp;
        start++;
        end--;
    }
}