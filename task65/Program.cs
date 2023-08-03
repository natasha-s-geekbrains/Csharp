// Задача 65: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа 
//в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int M = GetNum("Введите значение M (целое число > 0): ");
int N = GetNum("Введите значение N (целое число > M): "); // в примерах к задаче N > M
if (N <= M)
{
    Console.Write("Неверный ввод: второе число должно быть больше первого.");
}
Console.Write($"{GetNumbers(M, N)}");

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string GetNumbers(int x, int y)
{
    if (x <= y)
    {
        return x + " " + GetNumbers(x + 1, y);
    }
    else
    {
        return "";
    }
}

