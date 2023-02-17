// Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
Console.Write("Введите трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N > 99)
{
    Console.Write(N>99 ? N.ToString()[2] : '-');
}
else
{
    Console.Write("Третьей цифры нет");
}