// Программа проверка на кратность 7 и 23
Console.WriteLine("Enter your firstNumber");
int firstNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber%7 == 0 && firstNumber%23 == 0)
{Console.WriteLine("Your Number is good div");}
else
{Console.WriteLine("Your Number is NOT good div");}