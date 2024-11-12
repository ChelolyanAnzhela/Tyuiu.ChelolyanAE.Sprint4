using Tyuiu.ChelolyanAE.Sprint4.Task4.V16.Lib;

namespace Tyuiu.ChelolyanAE.Sprint4.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Двумерные массивы (ввод с клавиатуры)                               *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7. Заменить четные элементы *");
            Console.WriteLine("* массива на 1                                                            *");
            Console.WriteLine("*                                 6,5,6,7,3,                              *");
            Console.WriteLine("*                                 5,4,6,7,3,                              *");
            Console.WriteLine("*                                 5,5,5,6,5,                              *");
            Console.WriteLine("*                                 6,5,4,4,3,                              *");
            Console.WriteLine("*                                 4,5,4,5,5,                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($" Введите{i}{j} элемент массива");
                    matrix[i,j]= Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(matrix);
            Console.WriteLine($"Результирующий массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(res[i, j] + "\t");
                }
            }
            Console.ReadKey();
        }
    }
}
