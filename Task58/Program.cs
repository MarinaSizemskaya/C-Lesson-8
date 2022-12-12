// Задача 58: Задайте два двумерных массива (от 0 до 10). 
// Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4  и   3 4
// 3 2      3 3
// Результирующая матрица будет:
// 6 16
// 9 6

using System;
using static System.Console;
Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

int [,] array1 = GetArray(m,n,0,10);
PrintArray(array1);
WriteLine();
int [,] array2 = GetArray(m, n, 0, 10);
PrintArray(array2);
WriteLine();
int [,] resultArray = new int[m,n];


for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        {
            resultArray[i, j] += array1[i, j] * array2[i, j];
        }
    }
}
PrintArray(resultArray);
int [,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int [rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(min, max+1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
