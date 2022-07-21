//Домашняя работа по семинару(уроку) 8.
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного

Console.WriteLine("введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
ArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("первоначальный массив заполненный случайными числами");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1]) // < упорядочение строк по убыванию, > по возрастанию
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}

// дополнительно,  варинт упорядочить по столбцам
//  if (numbers[z, j] < numbers[z + 1, j]) // < упорядочение строк по убыванию, > по возрастанию
//             {
//                 int temp = 0;
//                 temp = numbers[z, j];
//                 numbers[z, j] = numbers[z + 1, j];
//                 numbers[z + 1, j] = temp;
//             }
//         }
//     }
// }
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями строк по убыванию");
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

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("введите количество строк в прямоугольном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов в прямоугольном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
ArrayRandomNumbers(numbers);
PrintArray(numbers);
int minsum = Int32.MaxValue;
int maxsum = Int32.MinValue; //дополнительно добавил, ниже считал еще в строке и максимальную сумму элементов
int indexsum = 0;
int indexsum1 = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexsum++;
    }
    // дополнительно сделал к задаче кроме (строке с нименьшой суммой) еще и с наибольшей суммой
    if (sum > maxsum)
        maxsum = sum;
    indexsum1++;
}

Console.WriteLine("номер строки с наименьшей суммой : " + (indexsum) + ", сумма равна: " + (minsum));
Console.WriteLine("номер строки с наибольшей суммой : " + (indexsum1) + ", сумма равна: " + (maxsum));

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

// Задача 62. Заполните спирально массив 4 на 4.

Console.WriteLine("Введите количество строк или столбцов в квадратный массив: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[n, n];

int num = 1;
int i = 0;
int j = 0;

while (num <= n * n)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

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