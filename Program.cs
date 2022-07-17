//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2

Console.Write($"Введите количество М чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] massNumbers = new int[num];

void InputNumbers(int num){
for (int i = 0; i < num; i++)
  {
    Console.Write($"Введите число номер {i+1}. ");
    massNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massNumbers)
{
  int count = 0;
  for (int i = 0; i < massNumbers.Length; i++)
  {
    if(massNumbers[i] > 0 ) count++; 
  }
  return count;
}

InputNumbers(num);

Console.WriteLine($"Количество чисел > 0 равно: {Comparison(massNumbers)} ");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];


void InputCoef()
{
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты уравнения (y = k * x + b):\n");
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значение коэффициента k: ");
            else Console.Write($"Введите значение коэффициента b: ");
            
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());

        }

    }
}


double[] Decision(double[,] coeff)
{
    crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1];
    return crossPoint;
}

void OutputResponse(double[,] coeff)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
    {
        Console.Write($"\nПрямые параллельны");
    }
    else
    {
        Decision(coeff);
        Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputCoef();

OutputResponse(coeff);