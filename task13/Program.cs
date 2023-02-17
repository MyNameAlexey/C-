

Console.WriteLine("Enter your firstNumber");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your secondNumber");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber*firstNumber == secondNumber || secondNumber*secondNumber == firstNumber)
{Console.WriteLine("Ваше условие в одном из случаев верно");}
else
{Console.WriteLine("Ваше условие ни в одном из случаев неверно!");}