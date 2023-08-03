// Задача 63: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

using System.Globalization;
using System.Reflection.Metadata.Ecma335;

int x = 1;
int y = 1;
int z = 1;
int N = GetNum("Ведите значение N: ");
Console.WriteLine("Метод 1");
FillNumbers(N); // МЕТОД 1 по возрастанию
Console.WriteLine();
Console.WriteLine("Метод 2");
Console.WriteLine(FillNum(y, N)); // МЕТОД 2 по возрастанию
Console.WriteLine("Метод 3");
Console.WriteLine(FillNumb(z, N)); // МЕТОД 3 по убыванию

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// МЕТОД 1 по возрастанию ************************************

void FillNumbers(int M)
{
    if (x <= M)
    {
        Console.Write($"{x} ");
        x++;
        FillNumbers(M);
    }
}

// МЕТОД 2 по возрастанию ************************************

string FillNum(int y, int P)
{
    if (y <= P)
    {
        return y + " " + FillNum(y + 1, P);
    }
    else
    {
        return "";
    }
}

// МЕТОД 3 по убыванию ************************************

string FillNumb(int z, int Q)
{
    if (z <= Q)
    {
        return FillNumb(z + 1, Q) + z + " ";
    }
    else
    {
        return "";
    }
}

