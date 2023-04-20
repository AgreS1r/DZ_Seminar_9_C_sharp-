// Задача 68: Даны два неотрицательных числа M и N. Напишите программу вычисления функции Аккермана с помощью рекурсии.

Console.Clear();
Console.Write("Введите неотричательное число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Функция Аккермана для чисел ({M},{N}) = {AckermanFunction(M, N)}");

int AckermanFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
return AckermanFunction(numberM, numberN);
}

