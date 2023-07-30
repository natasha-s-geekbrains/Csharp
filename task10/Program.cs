// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.

int SecondDigit(int num1)
{
    return num1 / 10 % 10;
}

void PrintSecondDigit(int num2)
{
    Console.WriteLine("Вторая цифра вашего числа - " + num2 +".");
}

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());


if (number < 100 || number > 999)
{
    Console.WriteLine("Это не трехзначное число. Начните заново.");
}
else
{
    int secondDigit = SecondDigit(number);
    PrintSecondDigit(secondDigit);
}

