//      Задача со звездочкой Найти второй максимум в массиве.
//      4, 4, 3, 0, 2 => 3

int SecondMax(int[] arr)
{
    int max1 = arr[0];
    int max2 = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max1)
        {
            max2 = max1;
            max1 = arr[i];
            continue;

        }
        if (arr[i] > max2 & arr[i] != max1)
        {
            max2 = arr[i];
        }

    }
    return max2;
}

int [] arr = {3, 5, 3, 0, 4};
Console.WriteLine(SecondMax(arr));
