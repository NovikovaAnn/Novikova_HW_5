//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int sum = 0;
// int n = new Random().Next(2, 12);
// int[] ArrayA = CreateRandomArray(n, 100, 999);
// for (int i = 0; i < n; i++)
// {
//     if (ArrayA[i] % 2 == 0)
//     {
//         sum = sum + 1;
//     }
// }
// ShowArray(ArrayA);
// Console.Write(" --> " + sum);

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input start: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input end: ");
// int end = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(size, start, end);
// int sum = 0;
// for (int i = 1; i < newArray.Length; i = i + 2)
// {
//     sum = sum + newArray[i];
// }
// ShowArray(newArray);
// Console.Write(" --> " + sum);

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] CreateDoubleArray(int size, double min, double max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = min + new Random().NextDouble() * (max - min);
    }
    return array;
}
int n = new Random().Next(2, 10);
double[] Array = CreateDoubleArray(n, 10, 99);

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
ShowDoubleArray(Array);

double FindMax(double[] array)
{
    double Max = Array[0];
    double Min = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {

        if (Array[i] >= Max)
        {
            Max = Array[i];
        }
        else if (Array[i] <= Min)
        {
            Min = Array[i];

        }
    }
    return (Max - Min);
}
Console.WriteLine();
Console.WriteLine("Difference between max and min elements = " + FindMax(Array));