public class Solution
{
    public int Search(int[] nums, int target)
    {
        int len = nums.Length - 1;
        if (len == null)
            return -1;

        int low = 0, high = 0;
        for (int i = 0; i < len; i++)
        {
            if (nums[i + 1] < nums[i])
            {
                low = i + 1;
                high = i;
            }
        }

        if (target == nums[low])
        {
            return low;
        }
        else if (target == nums[high])
        {
            return high;
        }
        // find ranges
        int start = 0;
        if (target >= nums[start] && target <= nums[high])
        {
            return BS(nums, target, start, high);
        }
        else if (target >= nums[low] && target <= nums[len])
        {
            return BS(nums, target, low, len);
        }
        return -1;
    }
    private int BS(int[] nums, int target, int start, int high)
    {
        int m = (high + start) / 2;
        if (m == high)
            return m;

        if (target >= nums[start] && target <= nums[m])
        {
            return BS(nums, target, start, m);
        }
        else if (target >= nums[m] && target <= nums[high])
        {
            return BS(nums, target, m + 1, high);
        }
        return -1;
    }
}