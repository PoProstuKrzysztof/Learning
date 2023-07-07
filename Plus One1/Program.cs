using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

int[] ints = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
var solutionArray = Solution.PlusOne(ints);
foreach (var item in solutionArray)
{
    Console.Write(item + " ");
}

public static class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        StringBuilder stringBuilder = new();
        List<int> digitsArray = new List<int> { };
        foreach (var item in digits)
        {
            stringBuilder.Append(item);
        }

        var stringBuilderToInt = long.Parse(stringBuilder.ToString());
        stringBuilderToInt++;

        foreach (var digit in stringBuilderToInt.ToString())
        {
            digitsArray.Add(int.Parse(digit.ToString()));
        }

        return digitsArray.ToArray();
    }
}