//git remote add origin https://github.com/VitalyS2022/SeminarsCsharp.git
//git branch -M main
//git push -u origin main

//Домашняя работа по семинару 1
//Задача 2 Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//1 вариант без ввода с клавиатуры пользователем, ниже будет с вводом c клавиатуры
int a = 5;
int b = 7;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.WriteLine("max = ");
Console.WriteLine(max);

//другие цифры 
int a = 2;
int b = 10;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.WriteLine("max = ");
Console.WriteLine(max);

// другие цифры

int a = -3;
int b = -9;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.WriteLine("max = ");
Console.WriteLine(max);

//2 вариант ввод с клавиатуры пользователем
int a, b;

Console.Write("Input a number 5: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 7: ");
b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.WriteLine("max = ");
Console.WriteLine(max);

//2 вариант ввод с клавиатуры пользователем другие цифры
int a, b;

Console.Write("Input a number -3: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number -9: ");
b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.WriteLine("max = ");
Console.WriteLine(max);


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//1 вариант без ввода с клавиатуры пользователем, ниже будет с вводом c клавиатуры
int a = 2;
int b = 3;
int с = 7;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (с > max) max = с;
Console.WriteLine("max = ");
Console.WriteLine(max);

// другие цифры
int a = 44;
int b = 5;
int с = 78;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (с > max) max = с;
Console.WriteLine("max = ");
Console.WriteLine(max);

// другие цифры
int a = 22;
int b = 3;
int с = 9;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (с > max) max = с;
Console.WriteLine("max = ");
Console.WriteLine(max);

//2 вариант ввод с клавиатуры пользователем
int a, b, с;

Console.Write("Input a number 44: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 5: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 78: ");
с = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (с > max) max = с;
Console.WriteLine("max = ");
Console.WriteLine(max);

//2 вариант ввод с клавиатуры пользователем другие цифры
int a, b, с;

Console.Write("Input a number 2: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 3: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 7: ");
с = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (с > max) max = с;
Console.WriteLine("max = ");
Console.WriteLine(max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//1 вариант без ввода с клавиатуры пользователем, ниже будет с вводом c клавиатуры

int a = 4;
if (a % 2 == 0) 
Console.WriteLine("Четное");
else 
Console.WriteLine("Нечетное");

// другие цифры
int a = -3;
if (a % 2 == 0) 
Console.WriteLine("Четное");
else 
Console.WriteLine("Нечетное");

// другие цифры
int a = 7;
if (a % 2 == 0) 
Console.WriteLine("Четное");
else 
Console.WriteLine("Нечетное");

//2 вариант ввод с клавиатуры пользователем 
int a;

Console.Write("Input a number 4: ");
a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) 
Console.WriteLine("Четное");
else 
Console.WriteLine("Нечетное");

//2 вариант ввод с клавиатуры пользователем другие цифры

int a = -3;

Console.Write("Input a number -3: ");
a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) 
Console.WriteLine("Четное");
else 
Console.WriteLine("Нечетное");


int a;
Console.Write("Input a number 7: ");
a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) 
Console.WriteLine("Четное");
else 
Console.WriteLine("Нечетное");


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int n, current;

Console.Write("Input a number: ");
n = Convert.ToInt32(Console.ReadLine());

current = n * (-1);

while(current <=n)
{
    if (current % 2 == 0)
    Console.Write(current + " ");
    current++; //current = current + 1
}