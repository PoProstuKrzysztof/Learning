//int i;
//for (i = 0; i <= 10; i++)
//{
//    if (i == 4)
//    {
//        Console.Write(i + " "); continue; // contiune sprawia że wraca do początku loopa, a nie że idzie dalej
//    }
//    else if (i != 4)
//        Console.Write(i + " ");
//    else
//        break;
//}

int i, j;
int[,] arr = new int[2, 2];
for (i = 0; i < 2; ++i)
{
    for (j = 0; j < 2; ++j)
    {
        arr[i, j] = i * 17 + i * 17;
        Console.Write(arr[i, j] + " ");
    }
}