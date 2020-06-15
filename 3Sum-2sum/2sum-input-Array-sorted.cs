public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] data = new int[2];
        int lo = 0, hi = numbers.Length - 1;
         while(lo <= hi)
         {
             int sum = 0;
             sum = numbers[lo] + numbers[hi];
             if (sum < target)
             {
                 lo++;
             }
             else if (sum > target)
             {
                 hi--;
             }
             else 
             {
                 data[0] = lo + 1;
                 data[1] = hi + 1;
                 break;
             }
         }
        return data;
    }
}