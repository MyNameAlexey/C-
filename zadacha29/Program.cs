﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];
Random rand = new Random();
for    (int i=0; i<=7; i++)  
{
    arr[i] = rand.Next(-10,21);
}
Console.WriteLine(string.Join(", ", arr));