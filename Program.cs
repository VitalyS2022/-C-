//Решение задачи по контрольной работе

string[] array1 = new string[10] {"ACG6", "123", "F2G", "AQ", "12", "67", "890", "WERT", "A", "1"};
string[] array2 = new string[array1.Length];
int a = 0;

void massive(string[] array1, string[] array2)
{
   
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[a] = array1[i];
        a++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Вывод строк <= 3 символам: ");
massive(array1, array2);
PrintArray(array2);