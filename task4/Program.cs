﻿// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N/
// 4 

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = -N;
while(temp <= N)
{
    Console.Write($"{temp} ");
    temp++;// temp = temp + 1
}