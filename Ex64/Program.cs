// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите значение N : ");
int number = Convert.ToInt32(Console.ReadLine());

string GapNumber(int number)
{
    string result = "";
    if (number == 1)
    {
        result = "1";
    }
    else
    {
        result = GapNumber(number - 1) + "," + $"{number}";
    }
    return result;
}

string result = GapNumber(number);
Console.WriteLine($"N = {number}. Промежуток натуральных чисел: {result}");