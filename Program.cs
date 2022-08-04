using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// - Составить программу обмена значениями двух переменных (при возможности не создавать третью переменную).

Console.WriteLine("Добро пожаловать акуна макака! Введи пожалуйста 2 числа.");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());


Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine(a);
Console.WriteLine(b);
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("<==================================>");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
// a = 5
// b = 10

int num = (int)a;

a = b;
b = (int)num;

Console.WriteLine(a);
Console.WriteLine(b);