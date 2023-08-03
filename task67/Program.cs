// Задача 67: Напишите программу, которая будет принимать на вход 
//число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = GetNum("Введите целое число > 0: ");
Console.Write("Сумма цифр этого числа = ");
int resultSum = GetSum(number);
Console.Write(resultSum);

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int GetSum(int num)
{
    if (num > 0)
    {
        return num % 10 + GetSum(num / 10);
    }
    else
    {
        return 0;
    }
}


