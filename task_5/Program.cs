// ##Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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

//заполняет первую строку двумерного массива
int[,] FillTopRowInDoubleArray (int[,]doubleArray, int count, int startRow, int stopRow, int startCol, int stopCol)
{
    int i = 0 + startRow;
    for (int j=0 + startCol; j<doubleArray.GetLength(1)-stopCol; j++)
    {
        doubleArray[i,j] = count;
        count++;
    }
    return doubleArray;
}
//заполняет первую строку двумерного массива
int CountFillTopRowInDoubleArray (int[,]doubleArray, int count, int startRow, int stopRow, int startCol, int stopCol)
{
    int i = 0 + startRow;
    for (int j=0 + startCol; j<doubleArray.GetLength(1)-stopCol; j++)
    {
        doubleArray[i,j] = count;
        count++;
    }
    return count;
}

//заполняет самый правый столбец двумерного массива 
int[,] FillRightColInDoubleArray (int[,]doubleArray, int count, int startRow, int stopRow, int startCol, int stopCol)
{
    int j = doubleArray.GetLength(1)-1-stopCol;
    for (int i = 0 + startRow;i<doubleArray.GetLength(0)-stopRow;i++)
    {
        doubleArray[i,j] = count;
        count++;        
    }
    return doubleArray;
}   
//считает количесво шагов FillRightColInDoubleArray, возвращает count
int CountFillRightColInDoubleArray (int[,]doubleArray, int count, int startRow, int stopRow, int startCol, int stopCol)
{
    int j = doubleArray.GetLength(1)-1-stopCol;
    for (int i = 0 + startRow;i<doubleArray.GetLength(0)-stopRow;i++)
    {
        doubleArray[i,j] = count;
        count++;        
    }
    return count;
}   


//заполняет последнюю строку двумерного массива
int[,] FillBottomRowInDoubleArray (int[,]doubleArray, int count, int startRow, int stopRow, int startCol, int stopCol)
{
    int i = doubleArray.GetLength(0)-1-startRow;
    for (int j = doubleArray.GetLength(1)-1-startCol; j >= 0+stopCol; j--)
    {
        doubleArray[i,j] = count;
        count++;        
    }
    return doubleArray;
}
//считает количесво шагов FillBottomRowInDoubleArray, возвращает count
int CountFillBottomRowInDoubleArray (int[,]doubleArray, int count, int startRow, int stopRow, int startCol, int stopCol)
{
    int i = doubleArray.GetLength(0)-1-startRow;
    for (int j = doubleArray.GetLength(1)-1-startCol; j >= 0+stopCol; j--)
    {
        doubleArray[i,j] = count;
        count++;        
    }
    return count;
}

//заполняет самый левый столбец двумерного массива 
int[,] FillLeftColInDoubleArray  (int[,]doubleArray, int count, int startRow, int stopRow, int startCol, int stopCol)
{
    int j = 0 + startCol;
    for (int i = doubleArray.GetLength(0)-1-startRow; i >= 0 + stopRow; i--)
    {
        doubleArray[i,j] = count;
        count++;        
    }
    return doubleArray;
}
//считает количесво шагов FillLeftColInDoubleArray, возвращает count
int CountFillLeftColInDoubleArray  (int[,]doubleArray, int count, int startRow, int stopRow, int startCol, int stopCol)
{
    int j = 0 + startCol;
    for (int i = doubleArray.GetLength(0)-1-startRow; i >= 0 + stopRow; i--)
    {
        doubleArray[i,j] = count;
        count++;        
    }
    return count;
}


try
{
    // Console.Write("Введите количество строк: \t");
    // int m = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Введите количество столбцов: \t");
    // int n = Convert.ToInt32(Console.ReadLine());
    int m = 4;
    int n = 4;
    int[,]initialDoubleArray = new int[m,n];
    int startFrom = 10;
    int startRow = 0;
    int stopRow = 0;
    int startCol = 0;
    int stopCol = 0;    

    FillTopRowInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startFrom = CountFillTopRowInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startRow++;
    FillRightColInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startFrom = CountFillRightColInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startRow--;
    startCol++;
    FillBottomRowInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startFrom = CountFillBottomRowInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startRow++;
    stopRow++;
    startCol--;
    FillLeftColInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startFrom = CountFillLeftColInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startCol++;
    stopCol++;
    FillTopRowInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startFrom = CountFillTopRowInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startRow++;
    FillRightColInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startFrom = CountFillRightColInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    startRow--;
    startCol++;
    PrintDoubleArray(FillBottomRowInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol));
    // startFrom = CountFillBottomRowInDoubleArray (initialDoubleArray, startFrom, startRow, stopRow, startCol, stopCol);
    // Console.WriteLine(startFrom);
}
catch 
{
        Console.WriteLine("error");
}
