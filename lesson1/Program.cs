﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень, в которую необходимо возвести число");
int num2 = int.Parse(Console.ReadLine()!);

int GetResult(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}

Console.WriteLine($"{num1} в {num2} степени = {GetResult(num1, num2)}");
