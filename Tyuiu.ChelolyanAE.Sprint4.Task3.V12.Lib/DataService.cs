using System.Linq.Expressions;
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChelolyanAE.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns= array.Length/rows;
            int res=int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 2 && array[i, j] < res)
                    {
                        res= array[i, j];
                    }
                }
            }
            return res;
        }
    }
}
