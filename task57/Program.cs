// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

using System.Globalization;

int rows = GetNum("Введите количество строк двумерного массива: ");
int columns = GetNum("Введите количество рядов двумерного массива: ");
int[,] inArray = GetArray(rows, columns);
PrintMartixArray(inArray);
int[] rowArray = GetRowArray(inArray);
SortRowArray(rowArray);
Console.WriteLine(string.Join("; ", rowArray));
PrintResult(rowArray);


int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int rowNum, int columnNum)
{
    int[,] array = new int[rowNum, columnNum];
    for (int i = 0; i < rowNum; i++)
    {
        for (int j = 0; j < columnNum; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintMartixArray(int[,] arr)
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

int[] GetRowArray(int[,] startArray)
{
    int[] rowArray = new int[startArray.Length];
    int index = 0;

    for (int i = 0; i < startArray.GetLength(0); i++)
    {
        for (int j = 0; j < startArray.GetLength(1); j++)
        {
            rowArray[index] = startArray[i, j];
            index++;
        }
    }
    return rowArray;
}

void SortRowArray(int[] resultArray)
{
    for (int i = 0; i < resultArray.Length; i++)
    {
        for (int j = i + 1; j < resultArray.Length; j++)
        {
            int temp = 0;
            if (resultArray[i] > resultArray[j])
            {
                temp = resultArray[i];
                resultArray[i] = resultArray[j];
                resultArray[j] = temp;
            }
        }
    }
}

void PrintResult(int[] finalArray)
{
    int el = finalArray[0];
    int count = 1;
    for (int i = 1; i < finalArray.Length; i++)
    {
        if (finalArray[i] != el)
        {
            Console.WriteLine($"Количество {el} в массиве = {count}. ");
            el = finalArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"Количество {el} в массиве = {count}.");
}
