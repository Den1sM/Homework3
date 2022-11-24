// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точек");
Console.WriteLine("Точка А");

Console.WriteLine("Введите значение A [X]");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение A [Y]");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение A [Z]");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");

Console.WriteLine("Введите значение B [X]");
int x2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите значение B [Y]");
int y2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите значение B [Z]");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt (Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

Console.WriteLine(result);