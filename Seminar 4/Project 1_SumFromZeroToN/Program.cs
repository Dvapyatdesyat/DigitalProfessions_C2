// function

int GetSumm (int n)
{
int result = 0;
int count = 0;
while (count<n)
{
    count=count+1;
    result = result + count;
}
return result;
}

//user's input

int number = int.Parse(Console.ReadLine()!);

int result = GetSumm (number);

Console.WriteLine (result);

