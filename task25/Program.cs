// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int A = Prompt("Введите первое число: ");

int B = Prompt("Введите второе число: ");


int pow = 1;

for (int count = 1; count <= B; count++)
{
    pow *=  A;
}

Console.WriteLine($"{A * 1}, {B * 1} -> {pow}");