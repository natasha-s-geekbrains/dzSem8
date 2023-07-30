// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

using System.Globalization;

int rowsQty = GetNum("Введите кол-во строк двумерного массива (число > 0): ");
int columnsQty = GetNum("Введите число столбцов двумерного массива. Число должно быть > 0 и не равно числу столбцов: ");
int[,] inMatrix = GetMatrix(rowsQty, columnsQty);
PrintMatrix(inMatrix);
int[] sumsArray = GetRowsSumsArray(inMatrix);
Console.WriteLine($"Суммы по строкам -> {string.Join(" , ", sumsArray)}");
MinSum(sumsArray);


int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GetMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
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

int[] GetRowsSumsArray(int[,] resultMatrix)
{
    int[] rowsSumsArray = new int[resultMatrix.GetLength(0)];
    int index = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            rowSum += resultMatrix[i, j];
        }
        rowsSumsArray[index] = rowSum;
        index++;
    }
    return rowsSumsArray;
}

void MinSum(int[] inRowArray)
{
    int minSum = inRowArray[0];
    int minSumRowIndex = 0;

    for (int i = 0; i < inRowArray.Length; i++)
    {
        if (inRowArray[i] < minSum)
        {
            minSum = inRowArray[i];
            minSumRowIndex = i;
        }
    }
    Console.WriteLine($"Минимальная сумма -> {minSum}");
    Console.WriteLine($"Строка номер {minSumRowIndex+1} имеет наименьшую сумму.");
}