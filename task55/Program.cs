//Задача 55: Задайте двумерный массив. 
//Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

using System.Globalization;

int rows = GetNum("Введите количество строк двумерного массива: ");
int columns = GetNum("Введите количество рядов двумерного массива: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
array = Change(array);
PrintArray(array);


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

int[,] Change(int[,] array)
{
    int[,] result = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j,i] = array[i,j];
        }
    }
    return result;
}
