// Задайте двумерный массив. Напишите программу, 
//которая поменяет местами две любые строки массива.
/*
int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(min, max +1);
        }
    }
return newArray;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeArrayRows(int[,] array1)
{
    Console.Write("Input 1st row: ");
    int row1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input 2nd row: ");
    int row2 = Convert.ToInt32(Console.ReadLine());

    if(row1 >= 0 && row1 < array1.GetLength(0) && row2 >= 0 && row2 < array1.GetLength(0) && row1 != row2)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            int temp = array1[row1, j];
            array1[row1, j] = array1[row2, j];
            array1[row2, j] = temp;
        }
    return array1;
    }
    else 
    {
        Console.WriteLine("Incorrect input! ");
        ChangeArrayRows(array1);
        return array1;
    }
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of column: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int[,] createdArray = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
ShowArray(createdArray);
ShowArray(ChangeArrayRows(createdArray));
*/

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//1 2 3 4  1 3 7 4
//3 4 5 6  2 4 8 5
//7 8 9 1  3 5 9 6
//4 5 6 7  4 6 1 7
/*
int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(min, max +1);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeArray(int[,] array2)
{
    if(array2.GetLength(0) <= 0 || array2.GetLength(1) <= 0)
    {
        Console.WriteLine("It should be matrix");
    }
    else
    {
        int[,] array3 = new int[array2.GetLength(1), array2.GetLength(0)];
        for(int i = 0; i < array2.GetLength(0); i++)
            for(int j = 0; j < array2.GetLength(1); j++)
            {
                array3[j,i] = array2[i,j];
            }
            ShowArray(array3);
    }
}
Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of column: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
ShowArray(newMatrix);
ChangeArray(newMatrix);
*/

// Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит строку и столбец,
// на пересечении которых расположен первый наименьший элемент массива.
/*
int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(min, max +1);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] GetMinIndex(int[,] inArray)
{
    int iMin = 0;
    int jMin = 0;
    for(int i = 0; i < inArray.GetLength(0); i++)
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if(inArray[i,j] < inArray[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
return new[] {iMin, jMin};
}
void GetZero(int[,] arrayStart, int[] minInd)
{
    for(int i = 0; i < arrayStart.GetLength(0); i++)
    {
        arrayStart[i, minInd[1]] = 0;
        for(int j = 0; j < arrayStart.GetLength(1); j++)
            arrayStart[minInd[0], j] = 0;
    }
ShowArray(arrayStart);
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of column: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
ShowArray(firstArray);
int[] minIndexArray = GetMinIndex(firstArray);
GetZero(firstArray, minIndexArray);
*/

//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
/*
int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(min, max +1);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrangeArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array1.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array1.GetLength(1) - 1; z++)
            {
                if (array1[i, z] < array1[i, z + 1])
                {
                int temp = 0;
                temp = array1[i, z];
                array1[i, z] = array1[i, z + 1];
                array1[i, z + 1] = temp;
                }
            }
        }
    ShowArray(array1);
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of column: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array1 = Create2dArray(user_rows,user_columns,user_minValue,user_maxValue);
ShowArray(array1);
ArrangeArray(array1);
*/

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] Create2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(min, max +1);
        }
    }
    return newArray;
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of column: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int[,] minArray = Create2dArray(user_rows,user_columns,user_minValue,user_maxValue);
ShowArray(minArray);

int sumElements = Int32.MaxValue;
int indexLine = 0;  
for (int i = 0; i < minArray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < minArray.GetLength(1); j++)
    {
        sum = sum + minArray[i, j];        
    }
        if (sum < sumElements)
        {
            sumElements = sum;
            indexLine++;
        }
}
Console.WriteLine($"Smallest row - {indexLine}  and sum of elements - {sumElements}");
*/

//Задача 58(дополнительно): Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
/*
int[,] Create2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(0, 10);
        }
    }
    return newArray;
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input numbers of row: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of column: ");
int user_columns = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = Create2dArray(user_rows,user_columns);
int[,] matrixB = Create2dArray(user_rows,user_columns);
ShowArray(matrixA);
ShowArray(matrixB);

void CompositionMatrix(int[,] resultArray)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < resultArray.GetLength(1); k++)           
            {
                resultArray[i, j] += (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
}
*/
// как вывести результат? не смог додумать... пошел спать

//Задача 60(дополнительно): ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
int[,,] array3D = new int[2, 2, 2];
Create3dArray(array3D);
ShowArray(array3D);

void ShowArray(int[,,] array)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void Create3dArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
/*
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input size Array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

ShowArray(array);
*/
