// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum (int numberM, int numberN)
{
    if (numberM == numberN)
    {
        return numberM;
    }
    return numberN + Sum(numberM, numberN - 1);
}

System.Console.Write("Введите минимальное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"{Sum(numberM, numberN)}");
