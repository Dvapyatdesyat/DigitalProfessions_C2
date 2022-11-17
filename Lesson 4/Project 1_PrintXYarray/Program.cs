// string [,] table = new string [2,5];
// table [1,2] = "word";

// for (int rows=0; rows<2; rows++)
// {
//     for (int columns=0; columns<5; columns++)
//     {
//         Console.WriteLine ($"-{table[rows,columns]}-");
//     }
// }




void Printarray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}

int[,] table = new int[3, 4];
Printarray(table);
FillArray (table);
Printarray(table);