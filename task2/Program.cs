/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int n, int m)
{
    if (n > m)
    {
       return 0;
    }
    return n + SumNumbers(n + 1, m);
}

int m = ReadInt("Введите начало промежутка -> ");
int n = ReadInt("Введите конец промежутка -> ");
System.Console.WriteLine($"Сумма чисел на отрезке [{n}; {m}] равна {SumNumbers(m, n)}");