// See https://aka.ms/new-console-template for more information

int [] FrequencyDictionary(int[,] matrix)
{
    int [] temp = new int [10];

    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j = 0, k = 0; j < matrix.GetLength(1); j++, k++)
        {
            if(matrix[i,j] == i+1)
                temp[i] = temp[i]++;
        }
    }
    
    return temp;
}