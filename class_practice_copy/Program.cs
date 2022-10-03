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

//