// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// Console.Clear();
// int[] array = {1,20,34,25,15,46,98,76,28,55};
// int result = 0;
// for(int i=0;i<10;i++)
// {
//     if(20 < array[i] && array[i]< 90)
//     {
//                 result = result + 1;
//     }
// }
// Console.WriteLine(result);

// Задача 2: Задайте массив из 10 целых чисел. Напишите программу, которая определяет количество четных чисел в массиве.
// Console.Clear();
// int[] array = {19,27,34,42,53,66,72,81,90,1012};
// int result = 0;
// for(int i=0; i<10; i++)
// {
//     if(array[i] % 2 == 0)
//     {
//         result++;
//     }
// }
// Console.WriteLine(result);

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальной и минимальным элементом массива.
// Console.Clear();
// double[] array = { 12312.3321, 1331.2134, 16123.3312, 1999.836, 8888.09231 };
// int count = array.Length;
// double min = array[0];
// for (int i = 1; i < count; i++)
// {
//     if (min > array[i])
//     {
//         min = array[i];
//     }
// }
//  double max = array [0];
//  for (int i = 1; i < count; i++)
// {
//     if (max <array[i])
//     {
//         max = array[i];
//     }

// }
// Console.WriteLine(max - min);