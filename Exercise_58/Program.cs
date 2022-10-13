// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
Console.Clear();
int[,] firstMatrix = new int[2,3];
int[,] secondMatrix = new int[3,3];
FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
PrintArray(secondMatrix);

int[,] multiplyMatrix = new int[2,3];
MultiplyMatrix(firstMatrix, secondMatrix, multiplyMatrix);
Console.WriteLine("The first matrix multiplied to second matrix equal:");
PrintArray(multiplyMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] multiplyMatrix)
{
  for (int i = 0; i < multiplyMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < multiplyMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      multiplyMatrix[i,j] = sum;
    }
  }
}

void FillArray(int[,] matrix)
{
    Random generator = new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = generator.Next(0,10);
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