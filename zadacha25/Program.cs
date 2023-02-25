// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Power(int number, int degree) 
 { 
     int result = 1; 

     for(int i = 1; i <= degree; i++) 
     { 
         result = result * number; 
     } 
     return result; 
 } 


 Console.Write("Введите число: "); 
 int drow = Convert.ToInt32(Console.ReadLine()); 
 Console.Write("Введите степень: "); 
 int drow2 = Convert.ToInt32(Console.ReadLine()); 

 Console.Write($"Итого: {Power(drow, drow2)}");