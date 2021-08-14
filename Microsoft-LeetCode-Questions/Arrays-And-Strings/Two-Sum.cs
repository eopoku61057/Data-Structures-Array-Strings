public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 0)
            return new int[2];

        var dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            var data = target - nums[i];
            if(dict.ContainsKey(data))
            {
                return new int[2] { dict[data], i };
            }
            else if (!dict.ContainsKey(data))
            {
                dict.Add(nums[i], i);
            }
        }

        return new int[2];
    }
}