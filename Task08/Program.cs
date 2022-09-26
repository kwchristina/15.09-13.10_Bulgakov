// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter integer:  ");
int n = Convert.ToInt32(Console.ReadLine());

int counter = 1;

while (counter <= n)
{
    if (counter % 2 == 0)
    {
        Console.Write($"{counter}");
        counter++;
    }
    counter++;
}

