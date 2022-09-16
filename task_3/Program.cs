// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Заполняет двумерный массив
int[,] FillDoubleArray(int row, int col)
{
    int[,] array = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(2,20);
            //Console.Write($"{array[i,j]} \t");
        }
    }
    return array;
}

// Печатает простой массив
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

// конвертирует указанную строку из двумерного массива в простой массив
int[] ConvertToRowSimpleArray(int[,] doubleArray, int row)
{
    int[] rowSimpleArray = new int[doubleArray.GetLength(1)];
    int count = 0;
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        rowSimpleArray[count] = doubleArray[row,j];
        //Console.Write($"{simpleArray[count]} \t");
        count++;
    }
    return rowSimpleArray;
}

// конвертирует указанный столбец из двумерного массива в простой массив
int[] ConvertToColSimpleArray(int[,] doubleArray, int col)
{
    int[] colSimpleArray = new int[doubleArray.GetLength(0)];
    int count = 0;
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        colSimpleArray[count] = doubleArray[i,col];
        //Console.Write($"{simpleArray[count]} \t");
        count++;
    }
    return colSimpleArray;
}

int[] MultiplicationOf2Arrays(int[]simpleArray1, int[]simpleArray2)
{
    int[] multiplyedArray = new int [simpleArray1.Length];
    for(int i=0;i<simpleArray1.Length;i++)
    {
        multiplyedArray[i] = simpleArray1[i]*simpleArray2[i];
    }
    return multiplyedArray;
}

int SumOfNumbersInArray(int[]simpleArray)
{
    int sumOfNumbersInArray = 0;
    for(int i=0;i<simpleArray.Length;i++)
    {
        sumOfNumbersInArray += simpleArray[i];
    }
    return sumOfNumbersInArray;
}

int[,] MultiplicationOf2Matrixs (int[,]initialDoubleArray1, int[,]initialDoubleArray2, int matrixSize)
{
    int[,] multiplicatedMatrix = new int [matrixSize,matrixSize];
    for(int i=0;i<multiplicatedMatrix.GetLength(0);i++)
    {
        for(int j=0;j<multiplicatedMatrix.GetLength(1);j++)
        {
            int[] rowSimpleArray = ConvertToRowSimpleArray(initialDoubleArray1, i);
            int[] colSimpleArray = ConvertToColSimpleArray(initialDoubleArray2, j);
            multiplicatedMatrix[i,j] = SumOfNumbersInArray(MultiplicationOf2Arrays(rowSimpleArray, colSimpleArray));
        }
    }
    return multiplicatedMatrix;
}

try
{
    Console.Write("Введите размер матрицы: \t");
    int size = Convert.ToInt32(Console.ReadLine());
    // int m = 2;
    // int n = 2;
    Console.WriteLine("Сгенерированная марица A:");
    int[,] initialDoubleArray1 = FillDoubleArray(size, size);
    PrintDoubleArray(initialDoubleArray1);
    Console.WriteLine("Сгенерированная марица B:");
    int[,] initialDoubleArray2 = FillDoubleArray(size, size);
    PrintDoubleArray(initialDoubleArray2);
    Console.WriteLine("Результат произведения матриц A и B:");
    PrintDoubleArray(MultiplicationOf2Matrixs (initialDoubleArray1, initialDoubleArray2, size));
}
catch 
{
        Console.WriteLine("error");
}