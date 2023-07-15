// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// СЛИШКОМ ПРОДВИНУТЫЙ МЕТОД
//*************************************************
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
//********************************************************

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] FillArray(int[] arrayA)
{
    for (int index = 0; index < arrayA.Length; index++)
    {
        arrayA[index] = new Random().Next(0, 2);
    }
    return arrayA;
}

void PrintArray(int[] arrayB)
{
    for(int idx = 0; idx < arrayB.Length; idx++)
    {
        Console.Write($"{arrayB[idx]} ");
    }
}

int arrayLength = Prompt("Введите длину массива: ");
int[] array = new int[arrayLength];

PrintArray(FillArray(array));

