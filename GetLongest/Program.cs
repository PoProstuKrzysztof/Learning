List<bool> values = new() { true, true, false, true, false, false, true, true, true, false, true, true, true, true };

int countLongestSequence = 0;

int count = 0;

for (int i = 0; i < values.Count; i++)
{
    if (values[i] == true)
    {
        count++;
        if (count >= countLongestSequence)
        {
            countLongestSequence = count;
        }
    }
    else
    {
        count = 0;
    }
}

Console.WriteLine(countLongestSequence);