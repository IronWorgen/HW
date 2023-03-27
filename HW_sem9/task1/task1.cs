//Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от m до N . 
//Выполнить с помощью рекурсии.
//
//M, N = 5, 8 -> "6, 8"
//M, N = 2, 4 -> "2, 4"

void PrintEvenBetweenMandN(int m, int n)
{
    if (m < n)
    {
        if (m >= n)
        {
            Console.Write(n);
            return;
        }
        if (m % 2 == 0) { Console.Write($"{m}, "); }
        PrintEvenBetweenMandN(m + 1, n);
    }
    else
    {
        if (m <= n)
        {
            Console.Write(n);
            return;
        }
        if (n % 2 == 0) { Console.Write($"{n}, "); }
        PrintEvenBetweenMandN(m, n + 1);
    }
}

PrintEvenBetweenMandN(8, 8);