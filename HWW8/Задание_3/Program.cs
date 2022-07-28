// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Программа вычисляет функцию Аккермана.");
Console.WriteLine("Задайте значение M: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N: ");
int nNumber = Convert.ToInt32(Console.ReadLine());
int AckermanFuncion(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermanFuncion(m - 1, 1);
    return AckermanFuncion(m - 1, AckermanFuncion(m, n - 1));
}
Console.WriteLine(AckermanFuncion(mNumber, nNumber));