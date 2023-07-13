// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int number = Prompt("Введите число: ");
int sum = 1;

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

while (sum <= number)
{
    Console.WriteLine($"{sum*sum}");
    sum++;
}
