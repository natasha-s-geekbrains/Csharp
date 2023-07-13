// Задача №17. Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
// ВАРИАНТ 2 нам показали на семинаре при разборе дз


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

string GetResult(int X, int Y)
{
    string res = String.Empty;
    if (X > 0 && Y > 0)
    {
        res = "I четверть";
    }
    else if (X < 0 && Y > 0)
    {
        res = "II четверть";
    }
    else if (X < 0 && Y < 0)
    {
        res = "III четверть";
    }
    else if (X > 0 && Y < 0)
    {
        res = "IV четверть";
    }
    return res;
}

int x = Prompt("Введите точку X: ");
int y = Prompt("Введите точку Y: ");
if (x == 0 || y == 0)
{
    Console.WriteLine("Неверный формат данных!");
}
else
{
    Console.WriteLine(GetResult(x, y));
}

