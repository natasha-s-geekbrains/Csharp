// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int GetRandomNumber()
{
    int number = new Random().Next(10, 100);
    return number;
}

int GetFirstDigit(int number1)
{
    // number1 = number 1 / 10 ИЛИ GetRandomNumber / 10;
    return number1 / 10;
}

int GetLastDigit(int number1)
{
    return number1 % 10;
}

void PrintNumber(int num1)
{
    Console.Write(num1 + " ");
}

void ShowLargestDigit(int digit1, int digit2)
{
    if (digit1 > digit2)
    {
        Console.WriteLine("-> " + digit1);
    }
    else Console.WriteLine("-> " + digit2);
}

int num = GetRandomNumber();
PrintNumber(num);
int firstDigit = GetFirstDigit(num);
//PrintNumber(firstDigit);
int lastDigit = GetLastDigit(num);
//PrintNumber(lastDigit);
ShowLargestDigit(firstDigit, lastDigit);

int num2 = GetRandomNumber();
PrintNumber(num2);
int firstDigit2 = GetFirstDigit(num2);
//PrintNumber(firstDigit);
int lastDigit2 = GetLastDigit(num2);
//PrintNumber(lastDigit);
ShowLargestDigit(firstDigit2, lastDigit2);
