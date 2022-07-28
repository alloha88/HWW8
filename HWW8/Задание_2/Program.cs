// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Эта программа покажет сумму натуральных чисел от M до N.");
Console.WriteLine("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = (n*(n + 1))/2 - ((m-1)*((m-1) + 1))/2;
Console.WriteLine("Сумма натуральных чисел от " + m + " до " + n + " -> " + sum);