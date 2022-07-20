// Практическая работа 7 по семинару 7
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("введите количество строк, n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов, m");
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



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("введите номер элемента в строке");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер элемента в столбце");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[5, 5];

ArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента в двумерном массиве нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}

PrintArray(numbers);

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-20, 20) / 2;
        }
    }
}

void PrintArray(int[,] array)
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

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк, n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов, m");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
ArrayRandomNumbers(numbers);


for (int i = 0; i < numbers.GetLength(0); i++)
{
    double avarage = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        avarage = (avarage + numbers[j, i]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
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
