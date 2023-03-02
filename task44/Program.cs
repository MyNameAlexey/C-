// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1 
//Если N = 7 -> 0 1 1 2 3 5 8 

Console.Write($"Введите число: ");
Void Fibonachi (int number)
{
    num1 = 0;
    num2 = 1;
    num3 = 0;
    for (int i = 0; i < number; i++)
        num3 = num1 + num2;
        num1 = num2;
        num2 = num3;
        Console.WriteLine($"{num3}");
}
