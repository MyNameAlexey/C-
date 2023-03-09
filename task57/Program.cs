// See https://aka.ms/new-console-template for more information

int[,] ArrayWithRandom(int row, int column)
{
    int[,] arr = new int[row, column];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1, 10);
        }
        
    }
    return arr;
}
int[,] ArrayWithRandom(int row, int column)
{
    int[,] arr = new int[row, column];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1, 10);
        }
        
    }
    return arr;
}

void FrequencyDictionary(int[,] matrix)
{
    int [] temp = new int [10];

    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[matrix[i,j]]++;
                
        }
    }
    Console.WriteLine(String.Join(" ",temp));
    //return temp;
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = ArrayWithRandom(row, column);
PrintMatrix(matrix);
Console.WriteLine();
FrequencyDictionary(matrix);