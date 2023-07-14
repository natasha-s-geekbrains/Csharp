// Задача 24: Напишите программу, 
//которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void GetSumNumber(int a)
{
    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
        sum += i; 
    }

Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
}

int A = GetNumber("Введите первое число: ");
GetSumNumber(A);

int B = GetNumber("Введите второе число: ");
GetSumNumber(B);
