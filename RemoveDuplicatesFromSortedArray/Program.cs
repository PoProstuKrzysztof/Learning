int[] numbers = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

Console.WriteLine( Solution.RemoveDuplicates( numbers ) );

public static class Solution
{
    public static int RemoveDuplicates(int[] nums)
    {
        var expectedResult = nums.Distinct().ToArray();

        for (int i = 0; i < expectedResult.Length; i++)
        {
            nums[i] = expectedResult[i];
        }

        for (int i = expectedResult.Length; i < nums.Length; i++)
        {
            nums[i] = 0;
        }

        return expectedResult.Length;
    }
}