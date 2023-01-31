// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void PrintNumbers(int number1, int number2)
{
    if (number1 == number2-1)
    {
        return;
    }
    PrintNumbers(number1-1, number2);
    Console.Write(number1 + " ");
}

Console.WriteLine("Enter the number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(m, n);