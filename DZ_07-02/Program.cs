/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void RandomArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
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
void Sverca(int[,] arr, int num)
{
    int s = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            s = arr[i, j];
            if (s == num)
            {
                System.Console.WriteLine($"Такой элемент есть: {s} !!!!!!!!!");
                return;
            }
        }
    }
    System.Console.WriteLine("Такого элемента нету((((((((");
}

int namber = ReadInt("Введите число совподающее с элементом в массиве:");
int[,] arrey = new int[6, 8];
RandomArrey(arrey);
PrintArrey(arrey);
Sverca(arrey, namber);
