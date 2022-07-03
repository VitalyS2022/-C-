int a, a2, a3;

Console.Write("Input a number 4: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 5: ");
a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 6: ");
a3 = Convert.ToInt32(Console.ReadLine());

int[] array = { a, a2, a3 };

int find = 5;

int index = 0;

while (index < 2)
{
    if (array[index] == 5)
    {

        //Console.WriteLine(index); // показывает номер индекса массива, покажет 1, так как считается от 0 
        Console.WriteLine(array[index]); //показывает число какое находится под номером индекса
        
    }
    //index = index + 1;
    index++;
}

