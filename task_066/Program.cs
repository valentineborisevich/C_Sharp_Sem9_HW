// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int RangeSum(int number1, int number2)
{
    if (number1 == number2)
    {
        return number2;
    }
    else if (number1 > number2)
    {
        return 0;
    }
    return number1 + RangeSum(number1 + 1, number2);
}
Console.WriteLine("Enter two numbers and I will return sum of all elements between them");
Console.WriteLine();
Console.WriteLine("Enter number1");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number2");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Sum = {RangeSum(m, n)}");