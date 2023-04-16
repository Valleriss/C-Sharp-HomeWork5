﻿/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


double[] array = GenerateArray(5);
PrintArray(array);
double result = FindMaxArrayElement(array) - FindMinArrayElement(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами = {result}");


double FindMaxArrayElement(double[] array) // Находит максимальный элемент массива
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMinArrayElement(double[] array) // Находит минимальный элемент массива
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] GenerateArray(int length) // Генерирует рандомный массив чисел с двумя знаками после запятой указанной длинны
{
    double[] array = new double[length];
    Random random = new Random();
    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(101, 1000);
        array[i] /= 100;
    }
    return array;
}

void PrintArray(double[] array) // Печатает массив
{
    Console.WriteLine($"[{string.Join("; ", array)}]");
}



