using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// - TASK [1]
// - Составить программу обмена значениями двух переменных (при возможности не создавать третью переменную).





//Console.WriteLine("Добро пожаловать акуна макака! Введи пожалуйста 2 числа.");

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());


//Console.ForegroundColor = ConsoleColor.Green;

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.BackgroundColor = ConsoleColor.Black;
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine("<==================================>");

//Console.BackgroundColor = ConsoleColor.Black;
//Console.ForegroundColor = ConsoleColor.White;
// a = 5
// b = 10

//int num = (int)a;

//a = b;
//b = (int)num;

//Console.WriteLine(a);
//Console.WriteLine(b);






// - TASK [2]
// Реализовать сравнение двух введенных с клавиатуры чисел. После сравнения, программа не должна закрываться, а должна ожидать ввод следующих цифр для сравнения
Console.WriteLine("Ну привет! Введи 2 числа");

for (int i = 0; i <= 100; i++)
{
    int first = Convert.ToInt32(Console.ReadLine());
    int second = Convert.ToInt32(Console.ReadLine());

    if (first is int && second is int)
    {
        if (first == second)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Awesome! That 2 numbers are eaqual!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oh shit! That 2 numbers are not eaqual! Try again ok?");

        }
    }
}







































