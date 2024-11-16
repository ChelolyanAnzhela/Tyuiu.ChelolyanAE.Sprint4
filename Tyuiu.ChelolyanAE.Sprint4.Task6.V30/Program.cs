using Tyuiu.ChelolyanAE.Sprint4.Task6.V30.Lib;
namespace Tyuiu.ChelolyanAE.Sprint4.Task6.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковой массив данных [\"Береза\", \"Дуб\", \"Клён\", \"Сосна\",  *");
            Console.WriteLine("* \"Пихта\", \"Осина\"], используя класс Array,выведите элементы массива, *");
            Console.WriteLine("*длина которых больше 5 символов.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var name = new string[] { "Береза", "Дуб", "Сосна", "Пихта", "Осина", "Клён" };
            Console.WriteLine("");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Элементы массива, длина которых больше 5: ");
            string[] mas = ds.Calculate(name);
            for (int i = 0; i < mas.Length; i++)
            {

                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
