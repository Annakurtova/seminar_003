/*
//19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

//14212 - нет
//12821 - да
//23432 - да

Console.Write("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());

if ((num{0} == num{4}) && (num{1} == num{1} == num{3}))
{
    Console.Write("Число является палиндромом");
}

else {
    Console.WriteLine("Нет");
}
*/

// Напишите программу, которая на вход принимает координаты двух точек и находит расстояние м-ду ними в 3д пространстве
// A(3,6,8)B(2,1,-7) -> 15.84

/*
Console.WriteLine("Введите кооординаты точки x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кооординаты точки z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кооординаты точки x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кооординаты точки z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(-x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine($"расстояние = {result:f2}");
*/

// Напишите программу, которая принимает на вход число н и выдает таблицу кубов чисел от1 до н

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

for (int index = 1; index <= num; index++)
{
    double result = Math.Pow(index,3);
    Console.WriteLine($"{result}" );
}