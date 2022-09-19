// ##Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Заполняет трехмерный массив случайными числами c проверкой на уникальность
int[,,] FillTripleArrayUniqueRandom(int row, int col, int depth, int randomFrom, int randomTo)
{
    int[,,] filledTripleArray = new int[row,col,depth];
    for (int z = 0; z < depth; z++)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                int randomNumber = 0;
                bool findStatus = false;
                do
                {
                    randomNumber = new Random().Next(randomFrom,randomTo);
                    findStatus = false;
                    foreach (int number in filledTripleArray)
                    {
                        if(number == randomNumber) findStatus = true;
                    }
                }
                while(findStatus == true);

                filledTripleArray[i,j,z] = randomNumber;
                //Console.Write($"{array[i,j,z]} \t");
            }
        }
    }
    return filledTripleArray;
}

// Печатает трехмерный массив
void PrintTripleArray(int[,,]tripleArray)
{
    for (int z = 0; z < tripleArray.GetLength(2); z++)
    {    
        for (int i = 0; i < tripleArray.GetLength(0); i++)
        {
            for (int j = 0; j < tripleArray.GetLength(1); j++)
            {
                Console.Write($"{tripleArray[i,j,z]} ({i},{j},{z}) \t");
            }
            Console.WriteLine();
        }
    }
}

// //Проверяет присутсвует ли число в любом массиве
// bool FindNumberInTripleArray(int number, int[,,] tripleArray)
// {
//     bool findStatus = false;
//     do
//     {
//         findStatus = false;
//         foreach (int i in tripleArray)
//         {
//             if(i == number) findStatus = true;
//         }
//     }
//     while(findStatus == true);
//     return findStatus;
// }


// // Заполняет трехмерный массив случайными числами
// int[,,] FillTripleArray(int row, int col, int depth)
// {
//     int[,,] filledTripleArray = new int[row,col,depth];
//     for (int z = 0; z < depth; z++)
//     {
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < col; j++)
//             {
//                 filledTripleArray[i,j,z] = new Random().Next(1,10);
//                 //Console.Write($"{array[i,j,z]} \t");
//             }
//         }
//     }
//     return filledTripleArray;
// }

// // Заполняет трехмерный массив чилами по-порядку, начиная с startFrom
// int[,,] FillTripleArrayStartFrom(int row, int col, int depth, int startFrom)
// {
//     int[,,] filledTripleArray = new int[row,col,depth];
//     for (int z = 0; z < depth; z++)
//     {
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < col; j++)
//             {
//                 filledTripleArray[i,j,z] = startFrom;
//                 startFrom++;
//                 //Console.Write($"{filledTripleArray[i,j,z]} \t");
//             }
//         }
//     }
//     return filledTripleArray;
// }


try
{
    Console.Write("Введите количество строк трехмерного массива: \t\t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов трехмерного массива: \t");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите глубину трехмерного массива: \t\t\t");
    int z = Convert.ToInt32(Console.ReadLine());
    // int m = 3;
    // int n = 4;
    // int z = 2;
    Console.WriteLine("Вот случайные неповторяющиеся значения трехмерного массива с индексами (i,j,z):");
    int[,,] initialTripleArray = FillTripleArrayUniqueRandom(m, n, z, 10, 100);
    PrintTripleArray(initialTripleArray);
    // Console.WriteLine("Введите число для поиска:");
    // int number = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine(FindNumberInTripleArray(number, initialTripleArray));
}
catch 
{
        Console.WriteLine("error");
}