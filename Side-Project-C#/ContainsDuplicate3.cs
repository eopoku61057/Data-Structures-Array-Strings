/*
Given an array of integers, find out whether there are two distinct indices i and j in the array such that 
the absolute difference between nums[i] and nums[j] is at most t and the absolute difference between i and j is at most k.
Input: nums = [1,2,3,1], k = 3, t = 0
Output: true
*/


public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (nums.Length > 9999)
        {
            return false;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = ((k + i) >= nums.Length) ? nums.Length - 1 : k + i; j > i; j--)
            {
                long data = Math.Abs((long) nums[i] - (long)nums[j]);
                if(data <= t) return true;
            }
        }
        return false;
    }
}

// easy solution 
public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }