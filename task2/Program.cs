// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
switch (day)
{
    case1: 
        Console.WriteLine("День недели Понедельник");
        break;
    case2: 
        Console.WriteLine("День недели Вторник");
        break;
    case3: 
        Console.WriteLine("День недели Среда");
        break;
    case4: 
        Console.WriteLine("День недели Четверг");
        break;
    case5: 
        Console.WriteLine("День недели Пятница");
        break;
    case6: 
        Console.WriteLine("День недели Суббота");
        break;
    case7: 
        Console.WriteLine("День недели Воскресенье");
        break;
    default:
        Console.WriteLine("День недели не задан");
        break;
}
    


