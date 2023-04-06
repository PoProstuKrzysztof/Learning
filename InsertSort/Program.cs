static void QuickSort(int[] arr, int low, int high)
{
    if (low < high)
    {
        //wybieranie elementu 'pivot'
        int partitionIndex = Partition( arr, low, high );
        //sortowanie od pivota w dół
        QuickSort( arr, low, partitionIndex - 1 );
        //sortowanie od pivota w góre
        QuickSort( arr, partitionIndex + 1, high );
    }
}

static int Partition(int[] arr, int low, int high)
{
    int pivot = arr[high];
    //licznik najmniejszej wartości
    int i = low - 1;
    for (int j = low; j < high; j++)
    {
        //jeśli element wskazany przez licznik pętli jest mniejszy od pivota
        if (arr[j] <= pivot)
        {
            //to dodaj licznik najmniejszej wartości i zamień element pętli razem z nim
            i++;
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    //swap
    int temp1 = arr[i + 1];
    arr[i + 1] = arr[high];
    arr[high] = temp1;
    return i + 1;
}