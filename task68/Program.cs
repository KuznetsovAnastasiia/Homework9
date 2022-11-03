/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ResultAkkermanFunction(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    if (number1 != 0 && number2 == 0)
    {
        return ResultAkkermanFunction(number1 - 1, 1);
    }
    if (number1 > 0 && number2 > 0)
    {
        return ResultAkkermanFunction(number1 - 1, ResultAkkermanFunction(number1, number2 - 1));
    }

    return ResultAkkermanFunction(number1, number2);
}

int m = InputMessage("Введите число m: ");
int n = InputMessage("Введите число n: ");
Console.WriteLine($"A(m,n) = {ResultAkkermanFunction(m, n)}");