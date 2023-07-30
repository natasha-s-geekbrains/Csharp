// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей 
// цифры нет.

int GetRandomNumber()
{
    int random = new Random().Next();
    return random;
}

int GetThirdDigit(int num1)
{
    while (num1 > 999)
    {
        num1 = num1 / 10;
    }
    return num1 % 10;
}

void PrintResult(int num2)
{
    Console.WriteLine("Третья цифра числа - " + num2);
}

int rand = GetRandomNumber();
Console.WriteLine("Случайное число = " + rand);

if (rand < 100)
{
    Console.Write("Третьей цифры нет.");
}
else
{
    int thirdDigit = GetThirdDigit(rand);
    PrintResult(thirdDigit);
}
