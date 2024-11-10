using Tyuiu.ChelolyanAE.Sprint4.Task3.V12.Lib;

namespace Tyuiu.ChelolyanAE.Sprint4.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Двумерные массивы (статический ввод)                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Найдите минимальный      *");
            Console.WriteLine("* элемент третьем столбце массива                                         *");
            Console.WriteLine("*                                 9,7,4,9,7,                              *");
            Console.WriteLine("*                                 5,2,5,7,6,                              *");
            Console.WriteLine("*                                 8,3,3,5,7,                              *");
            Console.WriteLine("*                                 8,4,2,4,5,                              *");
            Console.WriteLine("*                                 8,8,9,5,6,                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,]array=new int[5,5] { { 9, 7, 4, 9, 7 }, 
                                       { 5, 2, 5, 7, 6 },
                                        { 8, 3, 3, 5, 7 }, 
                                       { 8, 4, 2, 4, 5 }, 
                                       { 8, 8, 9, 5, 6 } };
            int rows=array.GetUpperBound(0)+1;
            int columns=array.GetUpperBound(1)+1;
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{array[i, j]}  \t ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine($"Минимальное значение в третьем столбце массива: {res}");
            Console.ReadKey();
        }
    }
}
