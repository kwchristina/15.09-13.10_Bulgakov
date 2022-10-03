// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter three-digit integer:  ");
int num = Convert.ToInt32(Console.ReadLine());
string secondDigit = Convert.ToString(num);

Console.WriteLine($"Second digit: {secondDigit[1]}");

