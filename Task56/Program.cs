// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;
Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

int [,] startArray = GetArray(m,n,0,10);
PrintArray(startArray);
Console.WriteLine();

int numOfRow = 0;
int summa = SumOfRow(startArray, 0);

for (int i = 1; i < startArray.GetLength(0); i++)
{
    int temp = SumOfRow(startArray, i);
    if (summa > temp)
    {
        summa = temp;
        numOfRow = i;
    }
}

Console.WriteLine($"\n{numOfRow+1} - строкa с наименьшей суммой элементов ({summa})");

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

int SumOfRow(int[,] inArray, int i)
{
  int sum = inArray[i,0];
  for (int j = 1; j < inArray.GetLength(1); j++)
  {
    sum += inArray[i,j];
  }
  return sum;
}