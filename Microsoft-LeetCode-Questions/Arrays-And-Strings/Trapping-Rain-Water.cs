public class Solution
{
    public int Trap(int[] height)
    {
        if (height.Length == 0) return 0;

        int l = 0, r = height.Length - 1, maxleft = 0, maxright = 0, result = 0;
        while (l <= r)
        {
            if (height[l] <= height[r])
            {
                if (height[l] >= maxleft)
                {
                    maxleft = height[l];
                }
                else
                {
                    result += maxleft - height[l];
                }
                l++;
            }
            else
            {
                if (height[r] >= maxright)
                {
                    maxright = height[r];
                }
                else
                {
                    result += maxright - height[r];
                }
                r--;

            }
        }
        return result;
    }
}