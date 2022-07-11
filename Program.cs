/*
Задача 64: Task64
Задача 66: Task66
Задача 68: Task68

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Inpit number m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Inpit number n: ");
int n = int.Parse(Console.ReadLine());
Console.Write(SumNumberBetween(m, n));

int SumNumberBetween(int m, int n)
{
    if (m == n) return m;
    else
        return m += SumNumberBetween(m + 1, n);
}