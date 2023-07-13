// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

string GetResult(int number)
{
    string res = String.Empty;
    if (number < 1 || number > 4)
    {
        res = "Значение не соответствует условию";
    }
    else
    {
        if (number == 1)
        {
            res = "x от 0 до + бескончности, y от 0 до + бесконечности";
        }
        else if (number == 2)
        {
            res = "x от 0 до - бескончности, y от 0 до + бесконечности";
        }
        else if (number == 3)
        {
            res = "x от 0 до - бескончности, y от 0 до - бесконечности";
        }
        else if (number == 4)
        {
            res = "x от 0 до + бескончности, y от 0 до + бесконечности";
        }
    }
    return res;
}

int sqr = Prompt("Введите номер четверти: ");
Console.WriteLine(GetResult(sqr));
