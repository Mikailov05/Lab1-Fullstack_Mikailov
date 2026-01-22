using System;

Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();

Console.WriteLine($"Привет, {name}!");
DayOfWeek today = DateTime.Now.DayOfWeek;
Console.WriteLine($"Сегодня: {today}")
Console.Write("Хотите продолжить? (y/n): ");
string answer = Console.ReadLine();

if (answer == "y")
{
    Console.WriteLine("Продолжаем работу...");
}
else
{
    Console.WriteLine("Завершение программы.");
}