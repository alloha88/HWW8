// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Эта программа покажет все натуральные числа от M до N.");
Console.WriteLine("Задайте значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
void FindNumber(int  m, int n)
{
    for(int i = m; i <= n; i++)
    {
        Console.Write(i + ", ");
    }
}
FindNumber(numberM, numberN);