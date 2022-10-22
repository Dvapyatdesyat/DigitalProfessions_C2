// мое решение недоделанное

Console.WriteLine("Введите число N");
int number = int.Parse(Console.ReadLine()!);

int X2(int number)

{
    double[] arrayOutput = new double[number];
    int count = 0;
    while (count < number)
    {
        arrayOutput[count] = Math.Pow(count, 2);
        count++;
    }
    return arrayOutput;
}

int i = 0;
while (i < arrayOutput.Length)
{
    Console.WriteLine(arrayOutput[]);
}

// Правильное решение


// Console.Clear(); Console.WriteLine();
// Console.Write("Введите число:   ");
// string writeN = Console.ReadLine()!;
// int N = Convert.ToInt32(writeN);
// int[] GetSqrtTable(int N)
// {
//     int[] SqrtArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         SqrtArray[i] = (i + 1) * (i + 1);
//     }
//     return SqrtArray;
// }
// void PrintTable(int[] Array)
// {
//     int number = 1; for (int i = 0; i < Array.Length; i++)
//     {
//         Console.WriteLine($"{number} ^ 2 = {Array[i]}"); number++;
//     }
// }
// int[] SqrtTable = GetSqrtTable(N);
// PrintTable(SqrtTable);