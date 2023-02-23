// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

//14212 - нет
//23432 - да
//12821 - да

//int[] array = {1, 4, 2, 1, 2}
//array[0] = 1;

string Promt(string message)
 {     
    Console.WriteLine(message);
    return Console.ReadLine();
       }  
bool CheckPol(string PolCand)
{     
    int len = PolCand.Length - 1;
    int index = 0;
while(index < len/2)
{
    if(PolCand [index] != PolCand [len - index])
    {
 return false;
    }
    index++;
}
return true;
 }  
string number = Promt("Введите число ");
bool RealPol = CheckPol(number);

if(RealPol)
{     
    Console.WriteLine("Да");
} 
else 
{     
    Console.WriteLine("Нет");
}  
