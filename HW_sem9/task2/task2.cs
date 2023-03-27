//  Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30

int SumBetweenMandN(int m, int n)
{
    int result = 0;
    if (m < n)
    {
        if (m >= n)
        {
            return result = n;
        }
        result += m + SumBetweenMandN(m + 1, n);
    }
    else
    {
        if (m <= n)
        {
            return result = n;
        }
        result += n + SumBetweenMandN(m, n + 1);
    }

    return result;
}

Console.WriteLine(SumBetweenMandN(1, 15));
