
int Acer(int m, int n)
{
    if(m == 0)
    
        return n + 1;
    
    
    else 
    
        if((m != 0) && (n == 0))
    
    return Acer(m - 1, 1);
    
    else    
    return Acer(m - 1, Acer(m, n - 1));
    
}

Console.Write("Введите число М ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"{Acer(numberM, numberN)}");

