
// int[,] matrix = new int[,] 
// {
//     {1,1,1,1},
//     {2,2,2,2},
//     {3,3,3,3}
// };

// int[,]matrix = {
//     {9,1,1,1},
//     {2,2,2,2},
//     {3,3,3,5}
// };

// static void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],4}");
//         }
//         Console.WriteLine();
//     }
// }
// PrintMatrix(matrix);

// создать двумерный массив из целых чисел.
// Вывести на экран "интереcные" элементы массива.
// Назовём число "интересным" если его сумма цифр четная

int[,] CreateMatrix(int row, int colums ,int min,int max)
{
    int[,] matrix = new int[row, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] matrix2D = CreateMatrix(5,4,1,1000);
PrintMatrix(matrix2D);

Console.WriteLine();
Console.Write(" => ");  
foreach (int c  in matrix2D)
{
    if (IsInteresting(c) == true)
    {
        Console.Write(c+" ");  
    }
}

bool IsInteresting(int value) //интересность числа
{
   int sumOfDigits = GetSumOfDigits(value);
   if (sumOfDigits % 2 == 0) // проверка суммы чисел на четность
   {
     return true;
   } 
   else
   {
    return false;
   }
}

int GetSumOfDigits(int value) //вычисление суммы цифр числа
{
   int sum = default;
   while (value > 0)
   {
    sum+=value % 10;
    value /= 10;
   }
   return sum;
}

// int IsEven() //проверка суммы чисел на четность
// {

// }






