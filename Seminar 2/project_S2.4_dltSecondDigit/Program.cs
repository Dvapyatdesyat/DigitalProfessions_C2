int number = new Random().Next(100, 1000);

Console.WriteLine("Generated number: " + number);

int DltSomeDigit (int number)
{
int firstDigit = number/100;
int thirdDigit = number%10;
int result;
return result = firstDigit*10+thirdDigit;
}

Console.WriteLine("Result: " + DltSomeDigit(number));