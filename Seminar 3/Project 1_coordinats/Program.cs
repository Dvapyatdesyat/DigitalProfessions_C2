int GetQuaterNumber(int x, int y)
{
    if (x == 0 || y == 0)
        return -1;
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

        return -1;
}

Console.WriteLine("Insert coordinats of point");
Console.WriteLine("Insert X");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Insert Y");
int y = int.Parse(Console.ReadLine()!);

int result = GetQuaterNumber(x, y);

if  (result > 0)
Console.WriteLine("Quater of the point: " + result);
else
Console.WriteLine("Wrong input");