// Задача 19: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно 
// палиндромом.

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void CheckPalindrom(int number)
{
    if (number < 10000 || number > 100000)
    {
        Console.WriteLine("Это число не пятизначное");
    }
    else
    {
        int digit1 = number / 10000;
        int digit2 = (number / 1000 ) % 10;
        int digit4 = (number / 10 ) % 10;
        int digit5 = number % 10;

        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine("Это число - палиндром");
        }
        else
        {
            Console.WriteLine("Это число - не палиндром");
        }
    }    
}

int X = Prompt("Введите пятизначное число: ");
CheckPalindrom(X);

