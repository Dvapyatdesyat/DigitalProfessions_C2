Console.WriteLine("Программа нахождения точки пересечения двух прямых");

// функция проверки ввода
double InputCheck()
{
    int inputValue;
    while ((!int.TryParse(Console.ReadLine()!, out inputValue)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение  
    {

        Console.WriteLine("Неверный ввод. Введите целое число");
        Console.WriteLine("Введите число заново: ");
    }
    double result = Convert.ToDouble(inputValue);
    return result;
}

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.,
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void SystemSolution(double k1, double k2, double b1, double b2)
{
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

}

Console.WriteLine("Введите коэфициент k1: ");
double k1 = InputCheck(); // введем число и проверим ввод
Console.WriteLine("Введите коэфициент b1: ");
double b1 = InputCheck(); // введем число и проверим ввод
Console.WriteLine("Введите коэфициент k2: ");
double k2 = InputCheck(); // введем число и проверим ввод
Console.WriteLine("Введите коэфициент b2: ");
double b2 = InputCheck(); // введем число и проверим ввод

SystemSolution(k1, k2, b1, b2);

