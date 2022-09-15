// #Урок 8. Как не нужно писать код. Часть 2
// ##Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// // заполняет случайными числами простой массив
// int[] FillSimpleArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1,100);
//         //Console.Write($"{array[i]} \t");   
//     }
//     return array;
// }

int[,] FillDoubleArray(int row, int col)
{
    int[,] array = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(1,100);
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

// Печатает двумерный массив
void PrintSimpleArray(int[]simpleArray)
{
    for (int i = 0; i < simpleArray.Length; i++)
    {
        Console.Write($"{simpleArray[i]} \t");
    }
        Console.WriteLine();
}

// сортирует значение в простом массиве
int[] SortArrayMinToMax(int[] simpleArray)
{
    int size = simpleArray.Length; 
    for (size = simpleArray.Length; size > 0; size--)
    {
        int maxInd = 0;
        for (int i = 0; i < size; i++)
        {
            if (simpleArray[i] > simpleArray[maxInd]) 
            {
                maxInd = i;
            }
        }
        int temp = simpleArray[size -1];
        simpleArray[size - 1] = simpleArray[maxInd];
        simpleArray[maxInd] = temp;
    }
    return simpleArray;
}

// конвертирует двумерный массив в одномерный
int[] ConvertToSimpleArray(int[,] doubleArray)
{
    int[] simpleArray = new int[doubleArray.GetLength(0)*doubleArray.GetLength(1)];
    int count = 0;
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            simpleArray[count] = doubleArray[i,j];
            //Console.Write($"{simpleArray[count]} \t");
            count++;
        }
    }
    return simpleArray;
}

// // из простого массива возвращает простой массив (заполняется, начиная с индекса 0) с количеством значений, равным количеству столбцов двумерного массива 
// int[] SeparateSimpleArrayAsColums(int[] simpleArray, int[,] initialDoubleArray)
// // из простого массива возвращает простой массив (заполняется, начиная с индекса 0) с количеством значений, равным количеству столбцов двумерного массива 
// {
    
//     int[]rowSimpleArrayAsColums = new int[initialDoubleArray.GetLength(1)];
//     int count = 0;
//     for(int j = 0; j < initialDoubleArray.GetLength(1); j++)
//     {
//         rowSimpleArrayAsColums[count] = simpleArray[count];
//         count++; 
//     }
//     return rowSimpleArrayAsColums;
// }

// из простого массива возвращает простой массив (заполняется, начиная с указанного в аргументе initialDoubleArray) с количеством значений, равным количеству столбцов двумерного массива
int[] SeparateSimpleArrayAsColums(int[] simpleArray, int simpleArrayIndex, int[,] initialDoubleArray)
{
    int rowSimpleArrayIndex = 0;
    int[]rowSimpleArray = new int[initialDoubleArray.GetLength(1)];
    for(int j = 0; j < initialDoubleArray.GetLength(1); j++)
    {
        rowSimpleArray[rowSimpleArrayIndex] = simpleArray[simpleArrayIndex];
        rowSimpleArrayIndex++;
        simpleArrayIndex++; 
    }
    return rowSimpleArray;
}

// // конвертирует указанную строку из двумерного массива в простой массив
// int[] ConvertToRowSimpleArray(int[,] doubleArray, int row)
// {
//     int[] rowSimpleArray = new int[doubleArray.GetLength(1)];
//     int count = 0;
//     for (int j = 0; j < doubleArray.GetLength(1); j++)
//     {
//         rowSimpleArray[count] = doubleArray[row,j];
//         //Console.Write($"{simpleArray[count]} \t");
//         count++;
//     }
//     return rowSimpleArray;
// }

// // конвертирует число в виде строки в массив из цифр
// int[] ConvertStringToArray()
// {
//     int i = 0;
//     Console.WriteLine("Введите число: ");
//     string string_number = Convert.ToString(Console.ReadLine());
//     int[] array = new int[string_number.Length];
//     for(i=0; i < string_number.Length; i++)
//     {
//         array[i] = int.Parse(string_number[i].ToString());
//         //Console.Write($"{array[i]} ");
//     }
//     return array;
// }

// // берет строку из двумерного массива, превращает в одномерный и сотрирует через другую функцию
// int[] MakeSortedRow(int[,] initialDoubleArray, int row)
// {
//     int[]rowArray = new int[initialDoubleArray.GetLength(1)];
//     int count = 0;
//     for(int j=0;j<initialDoubleArray.GetLength(1);j++)
//     {
//         rowArray[count] = initialDoubleArray[row,j];
//         count++;         
//     }
//     //PrintSimpleArray(rowArray);
//     int[] sortedRow = SortArrayMinToMax(rowArray);
    
//     return sortedRow;
// }


// // конвертирует простой массив в двумерный
// int[,] ConvertToDoubleArray(int[] simpleArray, int row, int col)
// {
//     int[,] doubleArray = new int[row,col];
//     int count = 0;
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             doubleArray[i,j] = simpleArray[count];
//             count++;
//         }
//     }
//     return doubleArray;
// }

try
{
    Console.Write("Введите количество строк: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: \t");
    int n = Convert.ToInt32(Console.ReadLine());
    // int m = 2;
    // int n = 3;
    Console.WriteLine("Вот сгенерированный двумерный массив:");
    int[,] initialDoubleArray = FillDoubleArray(m, n);
    PrintDoubleArray(initialDoubleArray);
    Console.WriteLine();
    Console.WriteLine("Вот мы его сконвертировали в одномерный массив:");
    int[] convertedSimpleArray = ConvertToSimpleArray(initialDoubleArray);
    PrintSimpleArray(convertedSimpleArray); 
    Console.WriteLine();
    
    Console.WriteLine("Вот мы разрезали одномерный массив на массивы, равные количеству столбцов в изначальном массиве, отсортировали массивчики, и вствили их в новый двумерный массив построчно:");
    int[] sortedRowArray = new int[initialDoubleArray.GetLength(1)];    
    int[,] sortedDoubleArray = new int[initialDoubleArray.GetLength(0),initialDoubleArray.GetLength(1)];    
    int row = 0;
    int convertedSimpleArrayIndex = 0;

    while (convertedSimpleArrayIndex < convertedSimpleArray.Length)
    {
    sortedRowArray = SortArrayMinToMax(SeparateSimpleArrayAsColums(convertedSimpleArray, convertedSimpleArrayIndex, initialDoubleArray));
    int sortedRowArrayIndex = 0;
        for (int j = 0; j < initialDoubleArray.GetLength(1); j++)
        {
            sortedDoubleArray[row,j] = sortedRowArray[sortedRowArrayIndex];
            sortedRowArrayIndex++;
        }
    row++;
    convertedSimpleArrayIndex = convertedSimpleArrayIndex + initialDoubleArray.GetLength(1);
    }
    PrintDoubleArray(sortedDoubleArray);
}
catch 
{
        Console.WriteLine("error");
}