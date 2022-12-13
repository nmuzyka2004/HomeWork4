/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели не число");
        }
    }
    return result;
}

void PrintDigitSumm(int number)
{
    int summ = number % 10;
    while (number >= 1)
    {
        number = number / 10;
        summ = summ + number % 10;
    }
    Console.WriteLine($"Сумма цифр заданного числа равна {summ}");
}

int number = Math.Abs(GetNumber("Введите число"));
PrintDigitSumm(number);