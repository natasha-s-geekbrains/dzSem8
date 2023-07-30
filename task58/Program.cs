// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

using System.Globalization;

int row1 = GetNum("Введите кол-во строк для первой матрицы: ");
int column1 = GetNum("Введите кол-во столбцов для первой матрицы: ");
int column2 = GetNum("Введите кол-во столбцов для второй матрицы: ");
int[,] inMatrix1 = GetMatrix(row1, column1);
int[,] inMatrix2 = GetMatrix(column1, column2);
PrintMatrix(inMatrix1);
Console.WriteLine();
PrintMatrix(inMatrix2);
Console.WriteLine();
int[,] resultMatrix = GetMatrix3(inMatrix1, inMatrix2);
PrintMatrix(resultMatrix);

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random random = new();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] someMatrix)
{
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            Console.Write($"{someMatrix[i, j]} | ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrix3(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}
