using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChelolyanAE.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
             int count = 0;
            foreach (string item in array)
            {
                if (item.Length > 5)
                {
                    count++;
                }
            }
            return count.Length;
        }
    }
}
