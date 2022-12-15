/* Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
//Метод получения числа с консоли
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

//Метод инициализации массива
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    for (int i = 0; i < dimension; i++)
    {
        array[i]= GetNumber("Введите очередное число массива"); 
    }
    return array;
}

//Метод печати массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}]");
}
int dimension = 8;
int[] array = InitArray(dimension);
PrintArray(array);
  