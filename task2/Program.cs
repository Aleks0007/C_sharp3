/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве. 

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Введите x1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите z1: ");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("");

Console.Write("Введите x2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите z2: ");
double z2 = double.Parse(Console.ReadLine()!);

double square1 = Math.Pow((x2 - x1), 2);
double square2 = Math.Pow((y2 - y1), 2);
double square3 = Math.Pow((z2 - z1), 2);

double distance = Math.Round((Math.Sqrt(square1 + square2 + square3)), 2);
Console.WriteLine($"Расстояние между точками = {distance}");