/*
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"   
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();
Console.WriteLine("Hello, World!");

// Методы

int CheckInputNumber(string Text)
{
    Console.ForegroundColor = ConsoleColor.Green;

    int number;
    string text;

    while (true)
    {
        Console.Write(Text);
        text = Console.ReadLine();

        if (int.TryParse(text, out number)) break;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Заданное значение числа не соответствует критерию, попробуйте еще раз.");
        Console.ResetColor();
    }
    Console.ResetColor();
    return number;
}

int CheckNatural(string text)
{
    int number;
    while (true)
    {
        number = CheckInputNumber(text);

        if (number < 0) Console.WriteLine("Задано отрицательное значение, попробуйте еще раз.");

        else if (number == 0) Console.WriteLine("Задано нулевое значение, попробуйте еще раз.");

        else break;
    }
    return number;
}

void OutNumbers(int number)
{
    if (number == 0) return;
    System.Console.Write(number + " ");
    OutNumbers(number - 1);
}

// Код задачи

int number = CheckNatural("Введите натуральное число: ");

Console.ForegroundColor = ConsoleColor.DarkCyan;
System.Console.WriteLine($"\nВсе натуральные числа в промежутке от {number} до 1 :\n");

OutNumbers(number);

Console.ResetColor();
System.Console.WriteLine("\n");
