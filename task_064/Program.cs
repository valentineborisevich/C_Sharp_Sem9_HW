// Все задачи решаются с помощью рекурсии
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbersInReverse(int number)
{
    if (number != 0)
    {
        Console.Write(number + " ");
        PrintNumbersInReverse(number - 1);
    }
}

Console.WriteLine("Enter the number and I will return all numbers from it to 1");
Console.WriteLine();
Console.WriteLine("Enter the number");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbersInReverse(n);