/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
  */

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Acker(int n, int m)
{
    while (n != 0)
    {

        if (m == 0)
        {
            m = 1;
        }
        else
        {
             m = Acker(n, m - 1);
        }
        n = n - 1;       
    }
    return m + 1;
}

    int m = ReadInt("Введите m -> ");
    int n = ReadInt("Введите n -> ");
    System.Console.WriteLine($"Значение функции Аккермана А({n}, {m}) = {Acker(m, n)}");