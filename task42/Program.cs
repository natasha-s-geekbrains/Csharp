// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num1 = Prompt("Введите десятичное число: ");

string collect = "";
int result = num1;

while (result > 0)
{
    
    collect = result % 2 + collect;

    result = result / 2;
}

Console.WriteLine(collect);

