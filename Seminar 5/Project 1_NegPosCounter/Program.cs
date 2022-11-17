int[] CreateArrayWithRandomNumbers(int numbers = 12, int startInterval = -9, int endInterval = 9) // метод содержит аргументы по умолчанию. Поэтому далее функция выводится без аргументов
{
    int[] result = new int[numbers];
    Random random = new();
    for (int i = 0; i < numbers; i++)
    {
        result[i] = random.Next(startInterval, endInterval + 1);

    }
    return result;
}

int SumPositiveNumbers(int[] input)
{
    int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] > 0)
            result += input[i];
    }
    return result;
}

int SumNegativeNumbers(int[] input)
{
    int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] < 0)
            result += input[i];
    }
    return result;
}

void PrintArray(int[] input)
{

    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i]);
        if (i != input.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("");
}

int[] array = CreateArrayWithRandomNumbers();
PrintArray(array);

int posSum = SumPositiveNumbers(array);
Console.WriteLine(posSum);

int negSum = SumNegativeNumbers(array);
Console.WriteLine(negSum);