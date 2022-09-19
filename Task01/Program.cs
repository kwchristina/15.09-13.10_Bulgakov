// Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго 
//например:
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 ->нет

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int square = b * b;
if (a == square)
{
    Console.WriteLine("Первое число ЯВЛЯЕТСЯ квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число НЕ ЯВЛЯЕТСЯ квадратом второго числа");
}
