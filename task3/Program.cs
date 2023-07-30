// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
switch (day)
{
    case 1: 
        Console.WriteLine("День недели Понедельник");
        break;
    case 2: 
        Console.WriteLine("День недели Вторник");
        break;
    case 3: 
        Console.WriteLine("День недели Среда");
        break;
    case 4: 
        Console.WriteLine("День недели Четверг");
        break;
    case 5: 
        Console.WriteLine("День недели Пятница");
        break;
    case 6: 
        Console.WriteLine("День недели Суббота");
        break;
    case 7: 
        Console.WriteLine("День недели Воскресенье");
        break;
    default:
        Console.WriteLine("День недели не задан");
        break;
}
    


