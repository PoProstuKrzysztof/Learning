//// See https://aka.ms/new-console-template for more information
//using System.Diagnostics;

//List<string> pricesList = new();

//int[] prices = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

//Console.WriteLine(LowestPriceInRecentDays(prices));

//static int LowestPriceInRecentDays(int[] arr)
//{
//    int lowestPrice = 10;
//    int currentDay = 0;

//    int[] duplicateArray = new int[] { };

//        List<int> priceList = new();

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < lowestPrice)
//        {
//            lowestPrice = arr[i];
//            duplicatePrice.Clear();
//            duplicatePrice.Push(lowestPrice);
//            priceList.Add(lowestPrice);

//        }
//        else if (duplicatePrice.Count == 7 && arr[i] > lowestPrice)
//        {
//            lowestPrice = arr[i];
//            duplicatePrice.Clear();
//            duplicatePrice.Push(lowestPrice);
//            priceList.Add(lowestPrice);
//        }
//        else
//        {
//            priceList.Add(lowestPrice);
//        }
//    }

//    priceList.Sort();

//    return priceList.First();
//}