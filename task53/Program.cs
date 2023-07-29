//Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами 
//первую и последнюю строку массива.

using System.Globalization;

int rows = GetNum("Введите количество строк двумерного массива: ");
int columns = GetNum("Введите количество рядов двумерного массива: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
int[,] finalArray = ChangeLines(array);
PrintArray(finalArray);

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[,] GetArray(int row, int column)
{
    int[,] res = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            res[i, j] = new Random().Next(1, 10);
        }
    }
    return res;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeLines(int[,] array)
{
    int[] temp = new int[array.GetLength(1)];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp[i];
    }
    return array;
}

