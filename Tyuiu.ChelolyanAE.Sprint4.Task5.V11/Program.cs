using Tyuiu.ChelolyanAE.Sprint4.Task5.V11.Lib;
namespace Tyuiu.ChelolyanAE.Sprint4.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Двумерные массивы (генератор случайных чисел)                      *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -7 до 2. Заменить положительные    *");
            Console.WriteLine("* элементы массива на 1                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix =new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i,j]= rnd.Next(-7,2);
                }
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
            }
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
