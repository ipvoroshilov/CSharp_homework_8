// ##Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// ##Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] FillDoubleArray(int row, int col)
{
    int[,] array = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(1,10);
            //Console.Write($"{array[i,j]} \t");
        }
    }
    return array;
}

// Печатает двумерный массив
void PrintDoubleArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

// суммирует значения в строках двумерного массива сохраняет их в простой массив
int[]ConvertSumInRowsToArray(int[,] initialDoubleArray)
{
    int count=0;
    int[]sumsArray = new int[initialDoubleArray.GetLength(0)];
    for(int i=0;i<initialDoubleArray.GetLength(0);i++)
    {
        int sum=0;
        for(int j=0;j<initialDoubleArray.GetLength(1);j++)
        {
            sum = sum + initialDoubleArray[i,j];
        }
        sumsArray[count] = sum;
        count++;
    }
    return sumsArray;
}

// находит индекс наименьшего значения простого массива
int IndexOfMinElement(int[] simpleArray)
{
    int indexOfMinElement = 0;
    for(int i=0;i<simpleArray.Length;i++)
    {
        if (simpleArray[i] < simpleArray[indexOfMinElement])
        {
            indexOfMinElement = i;
        }
    }
    return indexOfMinElement;
}

try
{
    Console.Write("Введите количество строк: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: \t");
    int n = Convert.ToInt32(Console.ReadLine());
    // int m = 2;
    // int n = 2;
    Console.WriteLine("Вот сгенерированный двумерный массив:");
    int[,] initialDoubleArray = FillDoubleArray(m, n);
    PrintDoubleArray(initialDoubleArray);
    int minimumRowSum = IndexOfMinElement(ConvertSumInRowsToArray(initialDoubleArray))+1;
    Console.WriteLine($"Строка двумерного массива, с наименьшей суммой элементов: {minimumRowSum}");
}
catch 
{
        Console.WriteLine("error");
}