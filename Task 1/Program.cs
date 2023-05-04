int[] arr = new int[] { 1, 2, 2, 3 };
int mostFrequent = 0;
int highestCount = 0;
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
        }
        if (count > highestCount)
        {
            highestCount = count;
            mostFrequent = arr[i];
        }
        count = 0;
    }
    if (highestCount == 1)
    {
        mostFrequent = -1;
    }
}

//int maxCount = 0;
//int mostFrequent = 0;
//Dictionary<int, int> frequency = new Dictionary<int, int>();

//foreach (int i in arr)
//{
//    if (frequency.ContainsKey( i ))
//    {
//        frequency[i]++;
//    }
//    else
//    {
//        frequency[i] = 1;
//    }

//    if (frequency[i] > maxCount)
//    {
//        maxCount = frequency[i];
//        mostFrequent = i;
//    }
//}

//return mostFrequent;
Console.WriteLine( mostFrequent );

static int ArrayChallenge(int[] arr)
{
    int mostFrequent = 0;
    int highestCount = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                count++;
            }

            if (count > highestCount)
            {
                highestCount = count;
                mostFrequent = arr[i];
            }

            count = 0;
        }

        if (highestCount == 1)
        {
            mostFrequent = -1;
        }
    }

    return mostFrequent;
}