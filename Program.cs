/*
Задача 64: Task64
Задача 66: Task66
Задача 68: Task68

Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.Write("Input number m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input number n: ");
int n = int.Parse(Console.ReadLine());
Console.Write(FunctionAnkermann(m, n));

int FunctionAnkermann(int m, int n)
{
    int result = 0;
    if (m == 0)
        return  result += n + 1;

    if (m > 0 && n == 0)
        return result += FunctionAnkermann(m - 1, 1);

    if (m > 0 && n > 0)
        return result += FunctionAnkermann(m - 1, FunctionAnkermann(m, n - 1));

    return result;
}