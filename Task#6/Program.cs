﻿/* 
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/


int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a % 2 == 0)
    Console.Write($"Число {a} четное");
else
    Console.Write($"Число {a} нечетное");