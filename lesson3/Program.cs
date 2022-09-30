/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/

Console.WriteLine("Введите 8 чисел");
string numbers = Console.ReadLine()!;
string [] digits = numbers.Split (' ');

PrintArray (CreatArray (8));

int [] CreatArray ( int size)
{
int [] array = new int [size];
for (int i = 0; i < size ; i++)
{
    array [i] = int.Parse(digits [i]);
}
return array;
}

void PrintArray (int[] array)
{
    Console.Write($"Ваш массив [{string.Join(", ", array)}]");
}