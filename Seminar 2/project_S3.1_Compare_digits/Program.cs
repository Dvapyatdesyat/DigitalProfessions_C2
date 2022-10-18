int number = new Random().Next(10, 100);

Console.WriteLine("Generated number: " + number);

int Compare (int number)
{
int maxDigit=0;
int firstDigit = number/10;
int secondDigit = number %10;
if (firstDigit>secondDigit)
{
    maxDigit=firstDigit;
}
else
{
maxDigit=secondDigit;
}
return maxDigit;
}

Console.WriteLine("Max digit: " + Compare(number));