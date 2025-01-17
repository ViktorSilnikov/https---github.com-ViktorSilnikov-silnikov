﻿// Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateAndFillArr(int large, int min, int max)
{
    int[] array = new int[large];
    for (int ifill = 0; ifill < array.Length; ifill++)
    {
        array[ifill] = new Random().Next(min, max + 1);
    }
    return array;
}

void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
int FindDifferenceBetweenMinMax(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    int difference = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    difference = max - min;
    return difference;
}
int[] myArray = CreateAndFillArr(10, 0, 50);
printArr(myArray);
var dif = FindDifferenceBetweenMinMax(myArray);
System.Console.WriteLine($"Difference betwen max and min = , {dif}");