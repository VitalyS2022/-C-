// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("введите номер строки, n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца, m");
int m = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[n, m];
ArrayRandomNumbers(numbers);
PrintArray(numbers);

void ArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-20, 20)) / 2; //цифры будут в диапазоне от -10 до 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}