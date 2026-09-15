int age = 15;
if (age >= 18)
{
    Console.WriteLine("Доступ разрешен");
}
else
{
    Console.WriteLine("Доступ запрещен");
    Console.WriteLine($"До совершеннолетия осталось {18-age} года");
}
Console.WriteLine("Программа продолжает работу");

int ade = 85;
if (ade < 13)
{
    Console.WriteLine("Ребенок");
}
else if (ade < 18)
{
    Console.WriteLine("Подросток");
}
else if (ade >= 60)
{
    Console.WriteLine("Пенсионер");
}
else
{
    Console.WriteLine("Взрослый");
}

int ages = 16;
double height = 1.55;
bool razresh = true;
if (ages >= 14 && height >= 1.5)
{
    Console.WriteLine("Можно кататься");
}
else if (razresh == true) 
{
    Console.WriteLine("кататься можно");
}


else
{
    Console.WriteLine("Пока нельзя");
}


