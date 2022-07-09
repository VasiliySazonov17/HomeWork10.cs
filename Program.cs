/*
Все задачи должны быть решены с помощью рекурсии!!!
Задача 64: Task64
Задача 66: Task66
Задача 68: Task68

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
*/
Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
NaturalNumber(number);

int NaturalNumber(int number)
{
    if (number == 1)
    {
        Console.Write($"{number}. ");
        return number;
    }
    else
    {
        Console.Write($"{number}, ");
        NaturalNumber(number - 1);
    }
    return number;
}