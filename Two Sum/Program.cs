public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int subtract = new int();
        for (int i = 0; i < nums.Length; i++)
        {
            subtract = target - nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] - subtract == 0)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { };
    }
}