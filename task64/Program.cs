/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void resultStringOfNumbers(int startNumber, int finalNumber)
{
    if (startNumber > finalNumber)
    {
        Console.Write(startNumber + " ");
        resultStringOfNumbers(startNumber - 1, finalNumber);
    }
    
    if (startNumber == finalNumber)
    {
        Console.Write(startNumber);
    }

    if (startNumber < finalNumber)
    {
        Console.WriteLine($"Введённое число N не является натуральным!");
    }
}

int startNumber = InputMessage("Введите натуральное число N: ");
int finalNumber = 1;
resultStringOfNumbers(startNumber, finalNumber);