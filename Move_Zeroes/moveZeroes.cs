private static int[] MoveZeroes(int[] nums)
        {
            if (nums.Length == 0)
                return nums;
            int zeroTrack = 0;
            for(int i = 0; i <= nums.Length - 1; i++)
            {
                if(nums[i] != 0)
                {
                    nums[zeroTrack] = nums[i];
                    zeroTrack++;
                }
            }
            while(zeroTrack <= nums.Length - 1)
            {
                nums[zeroTrack] = 0;
                zeroTrack++;
            }
            return nums;
        }