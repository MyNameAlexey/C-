

int [,] Matrix1 (int valueRow1, int valueColl1)
{
    int [,] newMatrix1 = new int [valueRow1, valueColl1];
    Random rnd = new Random();
    for (int i = 0; i < valueRow1; i++)
    {
        for (int j = 0; j < valueColl1; j++)
        {
            newMatrix1[i,j] = rnd.Next(0,10);
        }
    }
    return newMatrix1;
}

int [,] Matrix2 (int valueRow2, int valueColl2)
{
    int [,] newMatrix2 = new int [valueRow2, valueColl2];
    Random rnd = new Random();
    for (int i = 0; i < valueRow2; i++)
    {
        for (int j = 0; j < valueColl2; j++)
        {
            newMatrix2[i,j] = rnd.Next(0,10);
        }
    }
    return newMatrix2;
}

int [,] MatrixResult (int valueRowRes, int valueCollRes)
{
    int [,] MatrixRes = new int [valueRowRes, valueCollRes];
    {
        for (int i = 0; i < valueRowRes; i++)
    {
        for (int j = 0; j < valueCollRes; j++)
        {
            MatrixResult = MatrixRes(valueRowRes, valueCollRes);
            MatrixRes(valueRowRes, valueCollRes) = newMatrix1[valueRow1, valueColl1] * 
        }
    }
    }
    valueRowRes = {valueRow1} * {valueColl1}
    valueCollRes = {valueRow1} * {valueColl2}
}
return MatrixRes;

