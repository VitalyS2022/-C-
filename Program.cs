//Практическое задание 5 
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] numbers = new int[5]; //задаем массив из 5 значений

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int Quantitynumbers(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0) //деление без остатка(0), то четные числа
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 201); //задаем диапазон трехзначных чисел от 100 до 199
WriteArray(numbers);
Console.WriteLine();

int quantity = Quantitynumbers(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите число которое определяет размер массива");
int sizearray = Convert.ToInt32(Console.ReadLine()); //конвертируем введенный текст в число типа int;
int[] numbers = new int[sizearray]; //задается массив установленного нами размера
ArrayRandomNumbers(numbers); //Заполняется массив случайными числами через метод Void, который определен ниже;
Console.WriteLine("Все цифры массива: "); 
PrintArray(numbers); //Вывод всех чисел заданного массива
int sum = 0; //задаем первоначально переменную суммы = 0

for (int i = 1; i < numbers.Length; i+=2) //i = 1 пройдем по нечетным i+=2 - смотрим в массиве числа которые находятся на четных позициях, i = 0 пройдем по четным i+=2 
    sum = sum + numbers[i];

    Console.WriteLine($"сумма на нечётных позициях = {sum}");

void ArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10); //задаем наполнение массива случайными числами в диапазрне от 1 до 9
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] arrayNumbers = new double[5]; //задаем тип double так как вещественные числа, а не только целые числа типа int
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1, 11); //задаем диапазон случайных чисел от 1 до 10
    Console.Write(arrayNumbers[i] + " ");
  }

double max = arrayNumbers[0];
double min = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (max < arrayNumbers[i])
    {
      max = arrayNumbers[i];
    }
        if (min > arrayNumbers[i])
    {
      min = arrayNumbers[i];
    }
  }

  double result = max - min;

  Console.WriteLine($"разница между максимальным и минимальным элементом равна: {result}");