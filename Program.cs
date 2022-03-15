using System;

class Program
{
    static void Main(string []args)
    {
        // создадим 2 новые точки с использованием класса Point
        Console.WriteLine("***** Overloaded points comprasion *****");
        Point pt0 = new Point(99, 60);
        Point pt1 = new Point(52, 23);
        Point pt2 = new Point(44, 12);

        // выведем начальные значения
        Console.WriteLine("Point 1 = {0}", pt0);
        Console.WriteLine("Point 2 = {0}", pt1);
        Console.WriteLine("Point 3 = {0}", pt2);

        // разность для получения меньшей
        Console.WriteLine("Point 1 - Point 2: {0} ", pt0 - pt1);

        // -= использует перегрузку -
        Console.WriteLine("Point 2 -= Point 3: {0}", pt1 -= pt2);

        // унарный ++
        Console.WriteLine("++ Point 1 = {0}", ++pt0);

        // операция проверки на неравенство !=
        Console.WriteLine("Point 1 != Point 3: {0}", pt0 != pt2);

        // сравнение 
        Console.WriteLine("Point 2 < Point 3 : {0}", pt1 < pt2);
        Console.WriteLine("Point 2 >= Point 1 : {0}", pt1 >= pt0);


        Console.ReadLine();
    }
}