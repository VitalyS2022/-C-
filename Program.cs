//Домашняя работа пл семинару №2
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5

int a, a2, a3;

Console.Write("Input a number 4: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 5: ");
a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 6: ");
a3 = Convert.ToInt32(Console.ReadLine());

int[] array = { a, a2, a3 };

int index = 0;

while (index < 2)
{
    if (array[index] == a2)
    {

        //Console.WriteLine(index); // показывает номер индекса массива, покажет 1, так как считается от 0 
        Console.WriteLine(array[index]); //показывает число какое находится под номером индекса

    }
    //index = index + 1;
    index++;
}

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//782 -> 8

int a, a2, a3;

Console.Write("Input a number 7: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 8: ");
a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 2: ");
a3 = Convert.ToInt32(Console.ReadLine());

int[] array = { a, a2, a3 };

int index = 0;

while (index < 2)
{
    if (array[index] == a2)
    {

        //Console.WriteLine(index); // показывает номер индекса массива, покажет 1, так как считается от 0 
        Console.WriteLine(array[index]); //показывает число какое находится под номером индекса

    }
    //index = index + 1;
    index++;
}


//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//918 -> 1

int a, a2, b1;

Console.Write("Input a number 9: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 1: ");
a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 8: ");
b1 = Convert.ToInt32(Console.ReadLine());

int[] array = { a, a2, b1 };

int index = 0;

while (index < 2)
{
    if (array[index] == a2)
    {

        //Console.WriteLine(index); // показывает номер индекса массива, покажет 1, так как считается от 0 
        Console.WriteLine(array[index]); //показывает число какое находится под номером индекса

    }
    //index = index + 1;
    index++;
}


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5

int a, a2, a3;

Console.Write("Input a number 6: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 4: ");
a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 5: ");
a3 = Convert.ToInt32(Console.ReadLine());

int[] array = { a, a2, a3 };

int index = 0;

while (index <= 2)
{
    if (array[index] == a3)
    {

        //Console.WriteLine(index); // показывает номер индекса массива, покажет 1, так как считается от 0 
        Console.WriteLine(array[index]); //показывает число какое находится под номером индекса

    }
    //index = index + 1;
    index++;
}

// 78 -> третьей цифры нет

int a, a2;

Console.Write("Input a number 7: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 8: ");
a2 = Convert.ToInt32(Console.ReadLine());

int[] array = { a, a2 };

int index = 0;

while (index <= 2)
{
    if (index == 2)
    {

        //Console.WriteLine("показывет индекс элемента:" + index + "" + "Третьего числа нет"); // показывает номер индекса массива, покажет 1, так как считается от 0 
        //Console.WriteLine(array[index]); //показывает число какое находится под номером индекса
        Console.WriteLine("3 цифры нет"); 

    }
    //index = index + 1;
    index++;
}

32679 -> 6

int a, a2, a3, a4, a5;

Console.Write("Input a number 3: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 2: ");
a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 6: ");
a3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 7: ");
a4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 5: ");
a5 = Convert.ToInt32(Console.ReadLine());


int[] array = { a, a2, a3, a4, a5 };

int index = 0;

while (index < 5)
{
    if (array[index] == a3)
    {

        //Console.WriteLine(index); // показывает номер индекса массива, покажет 1, так как считается от 0 
        Console.WriteLine(array[index]); //показывает число какое находится под номером индекса

    }
    //index = index + 1;
    index++;
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

//1 вариант решение задачи
int a, a2, a3, a4, a5, a6, a7;


Console.Write("Input a number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 2 - вторник: ");
a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 3 - среда: ");
a3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 4 - четверг: ");
a4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 5 - пятница: ");
a5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 6 - суббота: ");
a6 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 7 - восресенье: ");
a7 = Convert.ToInt32(Console.ReadLine());


int[] array = { a, a2, a3, a4, a5, a6, a7 };

int index = 0;

while (index <= 6)
{
    if (array[index] == a)
    {
        Console.WriteLine("понедедьник - не выходной");
    }
    if (array[index] == a2)
    {
        Console.WriteLine("вторник - не выходной");
    }
    if (array[index] == a3)
    {
        Console.WriteLine("среда - не выходной");
    }
    if (array[index] == a4)
    {
        Console.WriteLine("четверг - не выходной");
    }
    if (array[index] == a5)
    {
        Console.WriteLine("пятница - не выходной");
    }
  if (array[index] == a6)
    {
        Console.WriteLine("суббота - выходной");
    }
      if (array[index] == a7)
    {
        Console.WriteLine("восресенье - выходной");
    }

    //index = index + 1;
    index++;
}

//2 вариант решение задачи

int a, a1, a2, a3, a4, a5, a6, a7;

a1 = 1;
a2 = 2;
a3 = 3;
a4 = 4;
a5 = 5;
a6 = 6;
a7 = 7;


Console.Write("Input a number: ");
a = Convert.ToInt32(Console.ReadLine());

if (a == a1)
{
    Console.WriteLine("понедедьник - не выходной");
}
if (a == a2)
{
    Console.WriteLine("вторник - не выходной");
}
if (a == a3)
{
    Console.WriteLine("среда - не выходной");
}
if (a == a4)
{
    Console.WriteLine("четверг - не выходной");
}
if (a == a5)
{
    Console.WriteLine("пятница - не выходной");
}
if (a == a6)
{
    Console.WriteLine("суббота - выходной");
}
if (a == a7)
{
    Console.WriteLine("восресенье - выходной");
}

