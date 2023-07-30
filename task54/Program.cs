// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

using System.Globalization;

int row = GetNum("Введите кол-во строк двумерного массива (число > 0): ");
int column = GetNum("Введите кол-во столбцов двумерного массива (число > 0): ");
int[,] inMatrix = GetMatrix(row, column);
PrintMatrix(inMatrix);
Console.WriteLine();
ShowSortedRows(inMatrix);


int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GetMatrix(int rowsQty, int columnsQty)
{
    int[,] startArray = new int[rowsQty, columnsQty];
    Random random = new();
    for (int i = 0; i < rowsQty; i++)
    {
        for (int j = 0; j < columnsQty; j++)
        {
            startArray[i, j] = random.Next(1, 100);
        }
    }
    return startArray;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void ShowSortedRows(int[,] someMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < inMatrix.GetLength(1); k++)
                if (inMatrix[i, j] < inMatrix[i, k])
                {
                    int temp = inMatrix[i, j];
                    inMatrix[i, j] = inMatrix[i, k];
                    inMatrix[i, k] = temp;
                }
            Console.Write($"{inMatrix[i, j]} | ");
        }
        Console.WriteLine();
    }
}

