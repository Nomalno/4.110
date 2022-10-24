Console.WriteLine("Номер масти карты (1-Пики, 2-Крести, 3-Бубен, 4-Червь ):");
int cardid = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Номер достоинства карты(11-Валет, 12-Дама, 13-Король, 14-Туз):");
int cardDignity = Convert.ToInt32(Console.ReadLine());
switch (cardDignity)
{
    case 6:
        Console.WriteLine("\t Шестерка");
        break;
    case 7:
        Console.Write("\t Семерка");
        break;
    case 8:
        Console.Write("\t  Восьмерка");
        break;
    case 9:
        Console.Write("\t Девятка");
        break;
    case 10:
        Console.Write("\t Десятка");
        break;
    case 11:
        Console.Write("\t Валет");
        break;
    case 12:
        Console.Write("\t Дама");
        break;
    case 13:
        Console.Write("\t Король");
        break;
    case 14:
        Console.Write("\t Туз");
        break;
}
switch (cardid)
{
    case 1:
        Console.Write(" пик");
        break;
    case 2:
        Console.Write("крести");
        break;
    case 3:
        Console.Write(" бубен");
        break;
    case 4:
        Console.Write(" червей");
        break;
}
Console.ReadKey();