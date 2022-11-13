Console.WriteLine("Программа подсчета количества цифр в числе");
Console.WriteLine("Введите целое число: ");
int number;

while ((!int.TryParse(Console.ReadLine()!, out number)))  //  пока не распарсилось, то выводим ошибку. Если все верно, то он запишет введенное значение в numA 
{

    Console.WriteLine("Неверный ввод. Введите целое число");
    Console.WriteLine("Введите число заново: ");
}

    double n = Math.Floor(Math.Log10(number)+1); // узнаем длину числа. MathFloor - округляет результат вычисления логарифма до ближайшего целого числа в сторону минус бесконечности


    Console.WriteLine($"число {number} содержит {n} цифр");

