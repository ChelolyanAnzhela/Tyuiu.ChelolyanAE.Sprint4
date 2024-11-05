﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChelolyanAE.Sprint4.Task1.V21.Lib
{
    public class DataService : ISprint4Task1V21
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    p*= array[i];
                }
            }
            return p;
        }
    }
}