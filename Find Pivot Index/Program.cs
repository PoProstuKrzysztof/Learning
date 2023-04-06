int[] nums = { 1, 7, 3, 6, 5, 6 };

string SendMessage(string message)
{
    return message;
}

Console.WriteLine( Solution.PivotIndex( nums ) );
string message = "typie";
MessageDelegate ms = new MessageDelegate( SendMessage );

internal delegate string MessageDelegate(string messsage);

public static class Solution
{
    public static int PivotIndex(int[] nums)
    {
        int totalSum = nums.Sum();
        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == (totalSum - leftSum - nums[i]))
            {
                return i;
            }
            leftSum += nums[i];
        }
        return -1;
        //int pivot = -1;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    int leftSum = 0,
        //   rightSum = 0;

        //    for (int j = 0; j < i; j++)
        //    {
        //        leftSum += nums[j];
        //    }

        //    for (int k = i + 1; k < nums.Length; k++)
        //    {
        //        rightSum += nums[k];
        //    }

        //    if (rightSum == leftSum)
        //    {
        //        return i;
        //    }
        //}

        //return pivot;
    }
}