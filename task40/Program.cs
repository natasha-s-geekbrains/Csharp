// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        Console.Write("Треугольник с такими сторонами существует.");
    }
    else
    {
        Console.Write("Треугольник с такими сторонами НЕ существует.");
    }
}


int a = Prompt("Введите первое число: ");
int b = Prompt("Введите второе число: ");
int c = Prompt("Введите третье число: ");

Triangle(a, b, c);

