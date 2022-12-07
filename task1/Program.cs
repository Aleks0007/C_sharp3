/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int revnum = 0;
int i = 0;
int x = num;

if (x >= 10000 && x < 100000)
{
    while (num > 0)
{
    i = num % 10;
    revnum =  revnum * 10 + i;
    num /= 10;
}
    if (x == revnum) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Число не является пятизначным");
}