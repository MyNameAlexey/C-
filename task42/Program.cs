// Задача 42: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное. 
//45 -> 101101 3  -> 11 2  -> 10

int num = Convert.ToInt32(Console.ReadLine());
string arr  = "";

while (num > 0)
{
    arr = arr + Convert.ToString(num % 2);
    num = num / 2;
}

 char[] charArray = arr.ToCharArray();
Array.Reverse(charArray);
Console.WriteLine(string.Join("",charArray));