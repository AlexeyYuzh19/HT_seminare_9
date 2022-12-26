/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120   
M = 4; N = 8. -> 30
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

bool Merge(int M, int N)
{
    if (N > M)
        return true;
    else
        return false;
}

void Swap(int M, int N, out int C, out int D)
{
    C = N;
    D = M;
}

void NaturalNumbers(int N, int M)
{
    if (N == M - 1)
    {
        return;
    }
    NaturalNumbers(N - 1, M);
    System.Console.Write($"  {N}");
}

int SummaNaturalNumbers(int M, int N)
{
    if (N == M)
    {
        return N;
    }
    return (N+SummaNaturalNumbers(M, N+1)); 
}

// Код задачи

int M = CheckNatural("Введите первое натуральное число : ");
metka:
int N = CheckNatural("Введите второе натуральное число : ");
if (M == N)
{
    System.Console.WriteLine("Числа равны, повторите ввод второго числа.");
    goto metka;
}
if (!Merge(M, N))
{
    Swap(M, N, out int C, out int D);
    M = C;
    N = D;
}

Console.ForegroundColor = ConsoleColor.DarkCyan;
System.Console.WriteLine($"\nBсе натуральные числа в промежутке от {M} до {N} :\n");

NaturalNumbers(N, M);

System.Console.WriteLine($"\n\nСумма натуральных элементов в промежутке от {M} до {N} равна : {SummaNaturalNumbers(N,M)}\n");
Console.ResetColor();




