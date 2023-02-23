// Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
//количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int Num(int n)
{
    string ns = n.ToString();
    return ns.Length;
}

System.Console.Write("Введите число: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = Num(a);
System.Console.WriteLine(result);