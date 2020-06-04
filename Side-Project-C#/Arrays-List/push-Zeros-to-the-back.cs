/* this method will push all existing zeros in an array to the back */

public void Movezeros(int[] nums)
{
    // this method fill the front of the array with non zero numbers
    // then fill the end of the array with zeros afterwards
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] != 0)
        {
            nums[count++] = nums[i];
        }
    }
    while(count < nums.Length)
    {
        nums[count++] = 0
    }
}

public void MoveZerosMethod2(int[] arr)
{ // this method is by moving all none zero element infront one after the other
    int count = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] != 0)
        {
            if(i != count)
            {
                int tmp = arr[count];
                arr[count] = arr[i];
                arr[i] = 0;
            }
            count++;
        }
    }
}