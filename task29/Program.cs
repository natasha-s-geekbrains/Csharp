// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 

int[] FillArray(int[] arrayA)
{
    for (int index = 0; index < arrayA.Length; index++)
    {
        arrayA[index] = new Random().Next(0, 100);
    }
    return arrayA;
}

void PrintArray(int[] arrayB)
{
    Console.Write("[");
    for (int idx = 0; idx < arrayB.Length; idx++)
    {
        if (idx == arrayB.Length - 1)
        {
            Console.Write($"{arrayB[idx]}]");
        }
        else
        {
            Console.Write($"{arrayB[idx]}, ");
        }
    }
}

int[] array = new int[8];
PrintArray(FillArray(array));
