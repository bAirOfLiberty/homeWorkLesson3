﻿// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
Console.Clear();
int[] array = {1,20,34,25,15,46,98,76,28,55};
int result = 0;
for(int i=0;i<10;i++)
{
    if(20 < array[i] && array[i]< 90)
    {
                result = result + 1;
    }
}
Console.WriteLine(result);