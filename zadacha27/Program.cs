// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int number = ReadInt("Введите число: ");
int Size = NumberSize(number);
SumNumbers(number, Size);


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция подсчета цифр в числе
int NumberSize(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int Size)
{
    int sum = 0;
    for (int i = 1; i <= Size; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
