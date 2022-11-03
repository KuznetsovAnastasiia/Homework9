/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ResultSumNumbers(int number1, int number2)
{
    if (number1 == number2)
    {
        return number1;
    }
    if (number1 > number2)
    {
        return number1 + ResultSumNumbers(number1 - 1, number2);
    }
    else
    {
        return number1 + ResultSumNumbers(number1 + 1, number2);
    }
}

int M = InputMessage("Введите число M: ");
int N = InputMessage("Введите число N: ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {ResultSumNumbers(M, N)}");