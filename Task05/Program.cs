﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter the first number:  ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number:  ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;
if (secondNumber > firstNumber)
    Console.WriteLine($"Maximum number: {secondNumber}");
else Console.WriteLine($"Maximum number: {firstNumber}");


