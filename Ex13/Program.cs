string[,] table = new string[2,5];
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]


// table[1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//    for (int columns = 0; columns < 5; columns++)
//    {
//     Console.WriteLine($"{table[rows, columns]}--");
//    } 
// }

int[,] matrix = new int[3, 4];

// for (int rows = 0; rows < 3; rows++)
// {
//     for (int columns = 0; columns < 4; columns++)
//     {
//         Console.Write($"{matrix[rows, columns]} ");
//     }
// Console.WriteLine();
// }

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
}
}


// int[,] matrix = new int[3, 4];

PrintMatrix(matrix);