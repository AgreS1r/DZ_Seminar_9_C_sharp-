﻿// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите натуральное число больше 1: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"N = {num}: ");
NaturalNumbers(num);

void NaturalNumbers(int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write(number + "  ");
    NaturalNumbers (number - 1);
}