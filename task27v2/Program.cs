// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int GetDigitSum(int number)
{
    int digitSum = 0;

    for (int i = number; i > 0; i /= 10)
    {
        digitSum += i % 10;
        number = i / 10;
    }
    return digitSum;
}

int num = Prompt("Введите число: ");
GetDigitSum(num);
Console.WriteLine($"{num} -> {GetDigitSum(num)}");


