/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все ЧЕТНЫЕ натуральные числа в промежутке от M до N. Выполнить с помощью рекурсии.
N = 5, M = 9 -> "6, 8"
N = 2, M = 10 -> "2, 4, 6, 8, 10" */

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintEvenNumbers(int n, int m)
{
    n += n % 2;
    if (n > m)
    {
       return;
    }
    System.Console.WriteLine(n);
    PrintEvenNumbers(n + 2, m);
}

int m = ReadInt("Введите начало промежутка -> ");
int n = ReadInt("Введите конец промежутка -> ");
PrintEvenNumbers(m, n);