/*
Задача 64: Task64
Задача 66: Task66
Задача 68: Task68

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Inpit m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Inpit n: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"{SumNumberBetween(m, n)}");


int SumNumberBetween(int m, int n)
{
    int sum = 0;
    if (m == n)
    {
        return m;
    }
    else
    {
        sum += SumNumberBetween(m + 1, n);
    }
    return m;
}