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

int shislo = int.Parse(Console.ReadLine());
if (shislo % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}

int cifra1 = int.Parse(Console.ReadLine());
int cifra2 = int.Parse(Console.ReadLine());
int cifra3 = int.Parse(Console.ReadLine());
if (cifra1 > cifra2 && cifra1 > cifra3)
{
    Console.WriteLine($"Наибольшее число {cifra1}");
}
else if (cifra2 > cifra1 && cifra2 > cifra3)
{
    Console.WriteLine($"Наибольшее число {cifra2}");
}
else
{
    Console.WriteLine($"Наибольшее число {cifra3}");
}
Console.WriteLine("Камень ножницы бумага");

string c1 = Console.ReadLine();
string c2 = Console.ReadLine();
if (c1 == c2)
{
    Console.WriteLine("Ничья");
}
else if (c1 == "К" && c2 == "Н")
{
    Console.WriteLine("Победа игрок 1");
}
else if (c1 == "Н" && c2 == "Б")
{
    Console.WriteLine("Победа игрок 1");
}
else if (c1 == "Б" && c2 == "К")
{
    Console.WriteLine("Победа игрок 1");
}
else if (c1 == "Н" && c2 == "К")
{
    Console.WriteLine("Победа игрок 2");
}
else if (c1 == "Б" && c2 == "Н")
{
    Console.WriteLine("Победа игрок 2");
}
else if (c1 == "К" && c2 == "Б")
{
    Console.WriteLine("Победа игрок 2");
}
else
{
    Console.WriteLine("Ошибка ввода");
}
