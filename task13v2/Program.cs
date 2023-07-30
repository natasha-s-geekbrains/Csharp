// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей 
// цифры нет.
//ВАРИАНТ 2 показан на следующем семинаре при разборе дз

string mess = "Введите число: ";

int number1 = Prompt(mess);
int number2 = Prompt("Введите пятизначное число: ");

int result1 = FindThirdNumber(number1);
int result2 = FindThirdNumber(number2);

GetResult(result1);
GetResult(result2);

void GetResult(int res)
{
    if (res == -1)
    {
        Console.WriteLine("Такой цифры нет!");
    }
    else
    {
        Console.WriteLine($"Третья цифра числа {res}");
    }
}

int Prompt(string message)
{
    //Console.Clear();
    Console.Write(message);
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return num;
}

int FindThirdNumber(int num)
{
    if (num < 100)
    {
        return -1;
    }
    else
    {
        while (num >= 1000)
        {
            num = num / 10;
        }
        int thirdNumber = num % 10;
        return thirdNumber;
    }
}




//from Elvira
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// string mess = "Введите число: ";
// int number1 = Prompt(mess);
// int number2 = Prompt("Введите пятизначное число");

// int result1 = FindThirdNumber(number1);
// int result2 = FindThirdNumber(number2);

// GetResult(result1);
// GetResult(result2);



// void GetResult(int res)
// {
//     if (res == -1)
//     {
//         Console.WriteLine("Такой цифры нет! ");
//     }
//     else
//     {
//         Console.WriteLine($"Третья цифра числа {res}");
//     }
// }



// int Prompt(string message)
// {
//     Console.Clear();
//     Console.WriteLine(message);
//     int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//     return num;
// }

// int FindThirdNumber(int num)
// {
//     if (num < 100)
//     {
//         return -1;

//     }
//     else
//     {
//         while (num >= 1000)
//         {
//             num = num / 10;
//         }
//         int thirdNumber = num % 10;
//         return thirdNumber;
//     }
// }
