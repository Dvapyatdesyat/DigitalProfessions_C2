Console.WriteLine("Программа определения параметров треугольника");


// функция проверки ввода
int InputCheck()
{
    int inputValue;
    while ((!int.TryParse(Console.ReadLine()!, out inputValue)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение  
    {

        Console.WriteLine("Неверный ввод. Введите целое число");
        Console.WriteLine("Введите число заново: ");
    }
    return inputValue;
}

// функция печати массива. В качестве аргумента предполагается использовать заполненный массив
void PrintArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Угол {i + 1}: {array[i]}");
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine(" ");
}


// функция решения задачи о треугольнике
void Triangle(int a, int b, int c)
{

    if (a < b + c && b < a + c && c < a + b)
    {
        TriangleSquare(a, b, c);
        TrianglePerimetr(a, b, c);
        float[] array = TriangleAngles(a, b, c);
        PrintArray(array);

        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] == 90)
            {
                Console.WriteLine("Треугольник является прямоугольным");

            }
        }

        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Треугольник является равнобедренным");
        }
        if (a == b && a == c && b == c)
        {
            Console.WriteLine("Треугольник является равносторонним");
        }
    }
    else
    {
        Console.WriteLine($"Треугольника со сторонами {a},{b},{c} не существует");
    }
}


// метод нахождения площади треугольника
void TriangleSquare(int a, int b, int c)
{
    double halfPerimetr = 0.5 * (a + b + c);
    double triangleS = Math.Sqrt(halfPerimetr * (halfPerimetr - a) * (halfPerimetr - b) * (halfPerimetr - c));
    Console.WriteLine($"Площадь треугольника: {triangleS}м2");
}

// метод нахождения периметр
void TrianglePerimetr(int a, int b, int c)
{
    double triangleP = a + b + c;
    Console.WriteLine($"Периметр треугольника: {triangleP}м.");
}
// метод нахождения значения углов треугольника в градусах
float[] TriangleAngles(int a, int b, int c)
{
    float[] SomeArray = new float[3];
    SomeArray[0] = MathF.Acos((Convert.ToSingle(Math.Pow(b, 2)) + Convert.ToSingle(Math.Pow(c, 2)) - Convert.ToSingle(Math.Pow(a, 2))) / (2 * b * c)) * (180 / MathF.PI);
    SomeArray[1] = MathF.Acos((Convert.ToSingle(Math.Pow(b, 2)) + Convert.ToSingle(Math.Pow(a, 2)) - Convert.ToSingle(Math.Pow(c, 2))) / (2 * b * a)) * (180 / MathF.PI);
    SomeArray[2] = 180 - SomeArray[0] - SomeArray[1];
    return SomeArray;
}


Console.WriteLine($"Введите длину первой стороны: ");
int side1 = InputCheck();
Console.WriteLine($"Введите длину второй стороны: ");
int side2 = InputCheck();
Console.WriteLine($"Введите длину третьей стороны: ");
int side3 = InputCheck();

Triangle(side1, side2, side3);