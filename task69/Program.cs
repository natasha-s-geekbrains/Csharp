// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int A = GetNum("Введите целое положительное число A: ");
int B = GetNum("Введите целое положительное число B: ");
int k = 1;
int resultPow = GetPow(A, B);
Console.Write($"А = {A}; В = {B} -> {resultPow}");

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int GetPow(int x, int y)
{
    if (y >= k)
    {
        return x * GetPow(x, y - 1);
    }
    else
    {
        return 1;
    }
}
