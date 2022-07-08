// // Домашняя работа по семинару 4
// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11; 82 -> 10; 9012 -> 12

Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int number = 0;

while (i > 0)
{
    number = i % 10; //оператор mod (%) для получения отдельных цифр числа тип int
    i = i / 10;
    sum = sum + number;
}
Console.WriteLine("Cумма всех цифр равна: " + sum);

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

//1 вариант - заполнение пользователем чисел в массив

Console.WriteLine("введите число");
string str = Console.ReadLine();
char[] arr = new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
    arr[i] = str[i];
}

//Console.WriteLine(arr); // чтобы цифры выходили на экране слева направо
Console.WriteLine(String.Join("\n", arr)); // чтобы цифры выходили на экран сверху вних
        

//2 вариант - заполнения рандомными числами массив
//создаю 2 массива, один из 5 элементов, другой из 3 элементов

int[] numbers = new int[5];
int[] numbers2 = new int[3];

Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1, 5); // Next(1, 6) - сделал диапазон случайных чисел от 1 до 5
    Console.Write(" " + Method(i) + " ");
}

Console.Write("][");

for (int j = 0; j < numbers2.Length; j++)
{
    numbers2[j] = new Random().Next(7, 11); // Next(7, 11) - сделал диапазон случайных чисел от 7 до 10
    Console.Write(" " + Method1(j) + " ");
}

int Method(int a)
{
    return numbers[a];
}

int Method1(int a)
{
    return numbers2[a];
}

Console.Write("]");

//3 вариант решения пользователь заполняет массив 

Console.WriteLine("введите число");
string str = Console.ReadLine();
char [] array = str.ToCharArray(); // преобразовать строку в массив буквально в одну строчку кода. Для этого всего лишь нужно воспользуемся уже готовым методом ToCharArray у метода char
Console.WriteLine(array);