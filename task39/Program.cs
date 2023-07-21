// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max);
    }
    return res;
}

void ReverseArray1(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] ReverseArray2(int[] arr)
{
    int[] revers = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        revers[i] = arr[arr.Length - 1 - i];
    }
    return revers;
}

int[] array = GetArray(11, 0, 15);
Console.Write(string.Join(" ", array));
ReverseArray1(array);
Console.WriteLine();
Console.Write(string.Join(" ", array));
ReverseArray2(array);
Console.WriteLine();
Console.Write(string.Join(" ", array));
