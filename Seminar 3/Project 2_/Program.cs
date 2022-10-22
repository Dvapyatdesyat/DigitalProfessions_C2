//напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат х и у 

int GetCoordinats(int numberOfQuater) // функция проверяет введенный номер четверти и выдает результат
{
    if (numberOfQuater == 1)
        return 1;
    if (numberOfQuater == 2)
        return 2;
    if (numberOfQuater == 3)
        return 3;
    if (numberOfQuater == 4)
        return 4;

    return -1;
}

Console.WriteLine("Insert number of quater");

int numberOfQuater = int.Parse(Console.ReadLine()!); // парсим введенное значение

// проверяем полученное в результате выполнения функции значение через else if. Финальный else выполняется тоьлко если не выполняются остальные услвоия
if (GetCoordinats(numberOfQuater) == 1) 
    Console.WriteLine("x от 0 до  +бесконечности ; y от 0 до +бесконечности");

else if (GetCoordinats(numberOfQuater) == 2)
    Console.WriteLine("x от -бесконечности до 0 ; y от 0 до +бесконечности");

else if (GetCoordinats(numberOfQuater) == 3)
    Console.WriteLine("x от -бесконечности до 0 ; y от -бесконечности до 0");

else if (GetCoordinats(numberOfQuater) == 4)
    Console.WriteLine("x от 0 до  +бесконечности; y от -бесконечности до 0");

else 
Console.WriteLine("Такой четверти не существует");


//альтернативный вариант:

//по четверти определить диапазон

//string GetRange(int quarter)
//{
    //if (quarter==1) return "x>0 & y>0";
   // if (quarter==2) return "x<0 & y>0";
    //if (quarter==3) return "x<0 & y<0";
    //if (quarter==4) return "x>0 & y<0";

    //return "unknown quarter";
//}

//Console.WriteLine("Enter the Quarter number:");
//int quarterNumber = int.Parse(Console.ReadLine()!);

//Console.WriteLine(GetRange(quarterNumber));
