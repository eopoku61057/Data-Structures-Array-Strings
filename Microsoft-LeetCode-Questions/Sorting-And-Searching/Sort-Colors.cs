public class Solution
{
    // time complexity = O(n)
    // space complexity = O(1)
    public void SortColors(int[] nums)
    {
        if (nums.Length == 0) return;
        int k = 0, j = nums.Length - 1;

        int i = 0;
        while (i <= j)
        {
            if (nums[i] == 0)
            {
                // swap
                Swap(nums, i, k);
                k++;
                i++;
            }
            else if (nums[i] == 2)
            {
                //sawp
                Swap(nums, i, j);
                j--;
            }
            else
                i++;
        }

    }
    private void Swap(int[] nums, int a, int b)
    {
        int tmp = nums[a];
        nums[a] = nums[b];
        nums[b] = tmp;
    }
}