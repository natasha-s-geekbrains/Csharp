// Задача №17. Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int x = Prompt("Введите точку x: ");
int y = Prompt("Введите точку y: ");

if(x!=0 && y!=0)
{
GetResult(x, y);
}
else
{
    Console.WriteLine("Неверный формат данных");
}

void GetResult(int X, int Y)
{
    if (X > 0 && Y > 0)
    {
        Console.WriteLine("I четверть");
    }

    if (X < 0 && Y > 0)
    {
        Console.WriteLine("II четверть");
    }

    if (X < 0 && Y < 0)
    {
        Console.WriteLine("III четверть");
    }

    if (X > 0 && Y < 0)
    {
        Console.WriteLine("IV четверть");
    }
}


// from Elvira with string
// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int Prompt(string message)
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }
// string GetResult(int X, int Y)
// {
//     string res = "";
//     if (X > 0 && Y > 0)
//     {
//         res = "I четверть";
//     }
//     else if (X < 0 && Y > 0)
//     {
//         res = "II четверть";
//     }
//     else if (X < 0 && Y < 0)
//     {
//         res = "III четверть";
//     }
//     else if (X > 0 && Y < 0)
//     {
//         res = "IV четверть";
//     }
//     return res;
// }


// int x = Prompt("Введите точку X: ");
// int y = Prompt("Введите точку Y: ");
// if (x == 0 || y == 0)
// {
//     Console.WriteLine("Неверный формат данных!");
// }
// else
// {
//     Console.WriteLine(GetResult(x, y));
// }
