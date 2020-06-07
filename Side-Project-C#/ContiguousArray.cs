/*
    Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1.
 */

 public int findMaxlength(int[] nums)
 {
     if(nums.Length == null) return -1;
     int max = 0, int count = 0;

     Dictionary<int, int> data = new Dictionary<int, int>();
     data.Add(0, -1);

     for (int i = 0; i < nums.Length; i++)
     {
         if (nums[i] == 0)
         {
             count += -1;
         }
         else 
         {
             count += 1
         }

         if (data.ContainsKey(count))
         {
             max = Math.Max(max, i - data.GetValueOrDefault(count));
         }
         else{
             data.Add(count, i);
         }
     }
 }