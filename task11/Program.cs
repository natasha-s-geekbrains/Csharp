// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


int GetRandomNumber()
{
int randNumber = new Random().Next(100, 1000);
return randNumber;
}

int GetFirstDigit(int numX)
{
    return numX / 100;
}

int GetLastDigit(int numY)
{
    return numY % 10;
}

void PrintNumber(int numZ)
{
    Console.WriteLine(numZ);
}

void PrintResult(int num1, int num2)
{
    Console.WriteLine(num1 + " -> " + num2);
}

int randNumber = GetRandomNumber();
PrintNumber(randNumber);
int firstDigit = GetFirstDigit(randNumber);
PrintNumber(firstDigit);
int lastDigit = GetLastDigit(randNumber);
PrintNumber(lastDigit);
int resultNumber = (firstDigit * 10 + lastDigit);
PrintResult(randNumber,resultNumber);


