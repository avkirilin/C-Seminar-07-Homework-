//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и возвращает
//значение этого элемента или же указание, что такого элемента нет.
int[,] GetArray(int rows, int columns, int minValue, int maxValue)                      //метод получения двумерного массива с рандомными значениями
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int FindItemInArray(int[,] array, int rows, int columns, int desiredNum)                //метод нахождения элемента по его порядковому номеру
{
    int searchingRow = desiredNum / columns;
    int searchingColumn = desiredNum % columns;
    int result = array[searchingRow, searchingColumn - 1];
    return result;
}

void PrintArray(int[,] inArray)                                                         //метод вывода двумерного массива с корректными отступами
{
    Console.WriteLine();
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] >= 0 && inArray[i, j] < 10) Console.Write($"     {inArray[i, j]}");
            if (inArray[i, j] >= 10 && inArray[i, j] < 100) Console.Write($"    {inArray[i, j]}");
            if (inArray[i, j] >= 100 && inArray[i, j] < 1000) Console.Write($"   {inArray[i, j]}");
            if (inArray[i, j] >= 1000 && inArray[i, j] < 10000) Console.Write($"  {inArray[i, j]}");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите кол-во строк и кол-во столбцов массива через пробел");
string[] f = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rowsArray = int.Parse(f[0]);
int columnsArray = int.Parse(f[1]);
Console.WriteLine("Введите минимальное и максимальное значения элементов массива в диапазоне 0-9999, через пробел");
string[] d = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int minNum = int.Parse(d[0]);
int maxNum = int.Parse(d[1]);
Console.WriteLine("Введите порядковый номер искомого элемента в массиве");
int indexNum = Convert.ToInt32(Console.ReadLine());
int[,] myArray = GetArray(rowsArray, columnsArray, minNum, maxNum);
PrintArray(myArray);
if (rowsArray * columnsArray >= indexNum) Console.WriteLine($"Значение искомого элемента массива равно: {FindItemInArray(myArray, rowsArray, columnsArray, indexNum)}");
else Console.WriteLine($"Искомое значение лежит за пределами заданного массива");