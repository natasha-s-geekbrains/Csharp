// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] GetSums(int[] arr)
{
    int[] res = new int[2];
    foreach (int el in arr)
    {
        //if (el > 0) positiveSum += el;
        //if (el < 0) negativeSum += el;
        if (el > 0) res[0] += el;
        if (el < 0) res[1] += el;
    }
    return res;
}

int sizeArray = GetNum("Введите длину массива: ");
int min = GetNum("Введите минимальное значение диапазона для элементов массива: ");
int max = GetNum("Введите максимальное значение диапазона для элементов массива: ");
int[] array = GetArray(sizeArray, min, max);
PrintArray(array);
int[] resSum = GetSums(array);
Console.WriteLine($"n\сумма положительных чисел = {resSum[0]}; сумма отрицательных чисел = {resSum[1]}");


//**********************************
// код от Эльвиры
// int sizeArray = GetNum("Введите длину массива: ");
// int min = GetNum("Введите минимальное значение диапазона для элементов массива: ");
// int max = GetNum("Введите максимальное значение диапазона для элементов массива: ");

// int[] array = GetArray(sizeArray, min, max);
// PrintArray(array);
// int[] resSum = GetSums(array);
// Console.WriteLine($"\nсумма положительных чисел = {resSum[0]} сумма отрицательных чисел={resSum[1]}");

// int GetNum(string message)
// {
//     Console.WriteLine(message);
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// int[] GetSums(int[] arr)
// {
//     int[] res = new int[2]; // [0,0]
//     foreach (int el in arr)
//     {
//         if (el > 0) res[0] = res[0] + el;
//         if (el < 0) res[1] += el;
//     }
//     return res;
// }
