// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void GetMultNumber(int num)
{
    int mult = 1;

    for (int i = 1; i <= num; i++)
    {
        mult *= i; 
    }

Console.WriteLine($"Произведение чисел от 1 до {num} = {mult}");
}

int A = GetNumber("Введите первое число: ");
GetMultNumber(A);

int B = GetNumber("Введите второе число: ");
GetMultNumber(B);


