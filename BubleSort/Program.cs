static void BubbleSort(int[] arr)
{
    int n = arr.Length;
    //przejście po każdym elemencie w tablicy
    for (int i = 0; i < n - 1; i++)
    {
        //porównywanie par elementów
        for (int j = 0; j < n - i - 1; j++)
        {
            //jeśli w parze element po lewej stronie będzie większy od prawej, zamienia się
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}