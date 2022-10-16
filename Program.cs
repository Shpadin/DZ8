
Console.WriteLine("Выберете задачу 54/ 56 / 58");
int task = int.Parse(Console.ReadLine());

switch (task)
{
    case 54:
        Task54();
        break;
    case 56:
        Task56();
        break;
    case 58:
        Task58();
        break;
    default:
        Console.WriteLine("Это нам не задавали! Это мы не проходили");
        break;

}

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}

void Task54()
{
 Console.WriteLine("  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
 Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    int[,] array = FillArray(rowCount, columnCount, 1, 100);
    PrintArray(array);

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
Console.WriteLine("А теперь все по порядку");
 SortToLower(array);
 PrintArray(array);


}
void Task56(){
Console.WriteLine(" Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
   Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    int[,] array = FillArray(rowCount, columnCount, 1, 100);
    PrintArray(array);

void SearchMinSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"В {minSumRow + 1} строке минимальная сумма элементов");
}
SearchMinSum(array);

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
}
void Task58(){
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

Console.WriteLine("Создаем Первую матрицу");
   Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    int[,] array1 = FillArray(rowCount, columnCount, 1, 100);
    PrintArray(array1);

Console.WriteLine("Создаем вторую матрицу");
   Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount2 = int.Parse(Console.ReadLine());

    int[,] array2 = FillArray(rowCount2, columnCount2, 1, 100);
    PrintArray(array2);

int[,] resultArray = new int[rowCount, columnCount];

    if (array1.GetLength(0) != array2.GetLength(1))
{
    Console.WriteLine("Эти мотрицы не возможно перемножить ");
    return;
}
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            resultArray[i, j] += array1[i, k] * array2[k, j];
        }
    }
}
   Console.WriteLine("Произведение матриц:");
 PrintArray(resultArray);

}