/* Задача 25: Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число");
        }
    }
    return result;
}

void GetExponent(int a, int b)
{
    double exponent = Math.Pow(a, b);
    Console.WriteLine($"{a} в степени {b} равно {exponent}");
}

int numberA = GetNumber("Введите число А");
int numberB = GetNumber("Введите число B");
GetExponent(numberA, numberB);

