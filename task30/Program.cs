// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// СЛИШКОМ ПРОДВИНУТЫЙ МЕТОД
// void Main()
// {
//     int[] array = new int[8];
//    // Random random = new Random();

//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(2);
//     }
//     Console.WriteLine("Массив: [" + String.Join(", ", array) + "]");
// }

// Main();

﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


