static void MergeSort(int[] arr, int left, int right)
{
    //łączenie dwóch tablic ze sobą
    if (left < right)
    {
        //wyznaczanie środka
        int middle = (left + right) / 2;
        //sortowanie lewej tablicy
        MergeSort( arr, left, middle );
        //sortowanie drugiej tablicy
        MergeSort( arr, middle + 1, right );
        //mergowanie dwóch tablic
        Merge( arr, left, middle, right );
    }
}

static void Merge(int[] arr, int left, int middle, int right)
{
    //wyznaczanie ilości elementów w lewej tablicy
    int n1 = middle - left + 1;
    //wyznaczanie ilości elementów w prawej tablicy
    int n2 = right - middle;
    int[] L = new int[n1];
    int[] R = new int[n2];
    int i, j;
    //wypełniane ich
    for (i = 0; i < n1; i++)
    {
        L[i] = arr[left + i];
    }
    for (j = 0; j < n2; j++)
    {
        R[j] = arr[middle + 1 + j];
    }
    i = 0;
    j = 0;
    int k = left;
    while (i < n1 && j < n2)
    {
        //wypełnianie elementów w tablicy wyjściowej
        if (L[i] <= R[j])
        {
            arr[k] = L[i];
            i++;
        }
        else
        {
            arr[k] = R[j];
            j++;
        }
        k++;
    }
    while (i < n1)
    {
        arr[k] = L[i];
        i++;
        k++;
    }
    while (j < n2)
    {
        arr[k] = R[j];
        j++;
        k++;
    }
}