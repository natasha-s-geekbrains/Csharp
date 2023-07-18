// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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
    Console.WriteLine();
}

void FindNumber(int[] arr)
{
    int number = GetNum("Введите искомое число: ");
    bool flag = false;
    foreach (int el in arr)
    {
        if (el==number) flag = true;
    }
    if(flag) Console.Write("Да");
    else Console.Write("Нет");
}

int sizeArray = GetNum("Введите длину массива: ");
int min = GetNum("Введите минимальное значение диапазона для элементов массива: ");
int max = GetNum("Введите максимальное значение диапазона для элементов массива: ");

int[] arr = GetArray(sizeArray, min, max);
PrintArray(arr);
FindNumber(arr);

