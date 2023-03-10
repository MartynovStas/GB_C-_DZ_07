/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


void RandomArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArry(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[,] arrey = new int[4, 4];
RandomArrey(arrey);
PrintArrey(arrey);

double[] Numbers = new double[arrey.GetLength(1)];

for (int i = 0; i < arrey.GetLength(1); i++)
{
    double summ = 0.0;
    for (int j = 0; j < arrey.GetLength(0); j++)
    {
        summ += arrey[j, i];
    }
    Numbers[i] = summ / arrey.GetLength(0);
}


PrintArry(Numbers);