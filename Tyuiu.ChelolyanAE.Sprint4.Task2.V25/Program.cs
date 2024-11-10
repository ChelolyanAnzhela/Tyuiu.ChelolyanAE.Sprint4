using Tyuiu.ChelolyanAE.Sprint4.Task2.V25.Lib;

namespace Tyuiu.ChelolyanAE.Sprint4.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Одномерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов, заполненный        *");
            Console.WriteLine("* случайными в диапазоне от 3 до 9. Подсчитать произведение четных        *");
            Console.WriteLine("* элементов массива                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                array[i] = rand.Next(3,9) ;
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine($"Произведение четных элементов массива: {res}");
            Console.ReadKey();
        }
    }
}
