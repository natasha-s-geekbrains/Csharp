// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// d = √((хА – хВ)2 + (уА – уВ)2),
// Math.Sqrt((x2-x1)Math.Pow(2,2)+(y2-y1)Math.Pow(2,2));

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int x1 = Prompt("Введите X для первой точки: ");
int y1 = Prompt("Введите Y для первой точки: ");
int x2 = Prompt("Введите X для второй точки: ");
int y2 = Prompt("Введите Y для второй точки: ");

double result = Math.Round(Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2)),2);

Console.WriteLine($"{result}");

