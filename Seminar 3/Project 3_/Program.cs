//void Reader ()
//{
//int number = int.Parse(Console.ReadLine()!);
//}


Console.WriteLine("Введите координаты точки А (х,y)");
int xa = int.Parse(Console.ReadLine()!);
int ya = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B (х,y)");
int xb = int.Parse(Console.ReadLine()!);
int yb = int.Parse(Console.ReadLine()!);

double Length(int xa, int ya, int xb, int yb)
{
    double result = 0;
    result =  Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2));
    return result;
}

Console.WriteLine("Длина отрезка " + Length(xa, ya, xb, yb));

//альтернативное решение

// //double distance (int[] dotsA, int[] dotsB)
// //{
//  //   return Math.Sqrt(Math.Pow(dotsA[0]-dotsB[0], 2)+Math.Pow(dotsA[1]-dotsB[1], 2));
// }

// int[] dotsA = new int[2];
// int[] dotsB = new int[2];

// Console.WriteLine("Enter the X(A):");
// dotsA[0] = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Enter the Y(A):");
// dotsA[1] = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Enter the X(B):");
// dotsB[0] = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Enter the Y(B):");
// dotsB[1] = int.Parse(Console.ReadLine()!);

// Console.WriteLine(Math.Round(distance(dotsA, dotsB),3));