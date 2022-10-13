// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
Console.Clear();
int[,] matrix = new int[5,5];
FillArray(matrix);
PrintArray(matrix);

int minSumRow = 0;
int sumRow = SumRows(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumRow = SumRows(matrix, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minSumRow = i;
  }
}
Console.WriteLine($"\nThe row #{minSumRow+1} has minimum sum equal {sumRow}");

int SumRows(int[,] matrix, int i)
{
    int sumRow = matrix[i,0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumRow += matrix[i,j];
    }
    return sumRow;
}

void FillArray(int[,] matrix)
{
    Random generator = new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = generator.Next(0,100);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine("");
    }
}