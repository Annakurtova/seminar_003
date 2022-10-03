/*
// Напишите программу, которая на вход принимает номер четверти и выводитдиапазон возможных значений для этой четверти

Console.WriteLine("Введите четверть: ");
int num = int.Parse(Console.ReadLine());
switch (num){
    case 1:
    {
        Console.WriteLine("Диапазон зн x > 0, y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine("Диапазон зна x < 0, y > 0");
    break;
    }
    case 3: 
    {
        Console.WriteLine("Диапазон зн x < 0, y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine("Диапазон зн x > 0, y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Четверть не существует");
        break;
    }

}
*/
/*
// Написать программу, которая принимает координаты точки, но при этом x  не равно 0 и игрек не равен 0 и выдае6т координаты на плоскости

Console.WriteLine("Введите кооординаты точки x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки y: ");
int y = int.Parse(Console.ReadLine());

if ((x > 0) && (y > 0))
{
    Console.WriteLine("Точка находится в 1й четверти");
}
else if ((x < 0) && (y > 0))
{
    Console.WriteLine("Точка находится в 2й четверти");
}
else if ((x < 0) && (y < 0))
{
    Console.WriteLine("Точка находится в 3й четверти");
}
else if ((x > 0) && (y < 0))
{
    Console.WriteLine("Точка находится в 4й четверти");
}
else
{
    Console.Write("Enter correct meanings");

}
*/

// Написать программу , которая на вход приниммает координаты 2 точек 2 и находит расстояние м-ду ними в 2д пространстве
// Math.Sqrt
// Console.WriteLine("d={d:f3});

/*
Console.WriteLine("Введите кооординаты точки x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кооординаты точки x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки y2: ");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
Console.WriteLine($"расстояние = {result:f3}");
*/

// Написать программу, которая на вход принимает число и выдает таблицу квадратов чисел от 1 до н

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

for (int index = 1; index <= num; index ++)
{
    double result = Math.Pow(index,2);
    Console.Write($"{result} ");
}

