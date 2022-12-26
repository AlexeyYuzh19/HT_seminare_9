/*
Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9   
m = 3, n = 2 -> A(m,n) = 29

Функция Аккермана:
A(m,n) = n + 1, если m = 0;
A(m,n) = A(m - 1, 1), если m > 0, n = 0;
A(m,n) = A(m - 1, A(m, n - 1)), если m > 0, n > 0;
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

int CheckPositiveNumber(string text)
{
    int number;
    while (true)
    {
        number = CheckInputNumber(text);

        if (number < 0) Console.WriteLine("Задано отрицательное значение, попробуйте еще раз.");

        else break;
    }
    return number;
}

// Код задачи

metka:
int M = CheckPositiveNumber("Введите первое неотрицательное число : ");

int N = CheckPositiveNumber("Введите второе неотрицательное число : ");

if (M == 0 && N == 0)
{
    System.Console.WriteLine("Оба числа равны 0, условие функции допускает зачение 0 для одного значения - повторите ввод чисел.");
    goto metka;
}

int AkkermanFunction(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }

    else if (M > 0 && N == 0)
    {
        return AkkermanFunction(M - 1, 1);
    }

    else
        return AkkermanFunction(M - 1, AkkermanFunction(M, N - 1));
}
Console.ForegroundColor = ConsoleColor.DarkCyan;
System.Console.WriteLine($"\nЗначение функции Аккермана для двух неотрицательных чисел М ({M}) и N ({N}) равно : {AkkermanFunction(M, N)}\n");
Console.ResetColor();
