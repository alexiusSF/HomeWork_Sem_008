﻿// Задача № 58
// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// 5 2 6 7
// и 
// 1 5 8 5 
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произвдедние будет равна следующему массиву:
// 1 20 56 10 
// 20 81 8 6 
// 56 8 4 24
// 10 6 24 49

int size = InputInt("Размер матриц: ");
Console.WriteLine();
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArray(matrixA);
FillArray(matrixB);

int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = (matrixA[i, j] * matrixB[i, j]);
        }
    }
}
Console.WriteLine("Матрица - А:");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В:");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц: А * В:");
PrintArray(matrixC);

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}