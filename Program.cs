//Домашняя работа по семинару №3
//Задача 19 
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет, 12821 -> да, 23432 -> да

1 вариант решения задачи 
Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] && number[1]==number[3]){
    Console.WriteLine("Число является палиндромом");
  }
  else Console.WriteLine("Число НЕ палиндром");
}

if (number.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine("Нужно вести число из 5 цифр");


//2 вариант решения задачи с помощью массивов

int a, a2, a3, a4, a5;

Console.Write("Input a number 1 ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 2 ");
a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 3 ");
a3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 4 ");
a4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 5 ");
a5 = Convert.ToInt32(Console.ReadLine());

int[] array = { a, a2, a3, a4, a5 };
int[] array2 = { a5, a4, a3, a2, a };

if (array[0] == array2[0])
    if (array[1] == array2[1])
        if (array[2] == array2[2])
            if (array[3] == array2[3])
                if (array[4] == array2[4])
                {
                    Console.WriteLine("Число является палиндромом");
                }
                else
                {
                    Console.WriteLine("Число не палиндром");
                }

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
