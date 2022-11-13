// function

int GetFactorial (int n)
{
int result = 1;
int count = 1;
while (count<n)
{
    count=count+1;
    result = result * count;
}
return result;
}

//user's input

int number = int.Parse(Console.ReadLine()!);

int result = GetFactorial (number);

Console.WriteLine (result);
