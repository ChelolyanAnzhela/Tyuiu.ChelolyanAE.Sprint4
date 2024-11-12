using Tyuiu.ChelolyanAE.Sprint4.Task5.V11.Lib;
namespace Tyuiu.ChelolyanAE.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] numsArray = new int[5, 5] { {-6,-5,-6,-7,0 },
                                               {-5,-4,-6,-7,2 },
                                               {-5,-5,-5,1,2 },
                                               {-6,-5,1,0,2 },
                                               {1,1,1,-5,-5 } };
            int[,] res = ds.Calculate(numsArray);
            int[,] wait = { {-6,-5,-6,-7,0 },
                            {-5,-4,-6,-7,1 },
                            {-5,-5,-5,1,1 },
                            {-6,-5,1,0,1 },
                            {1,1,1,-5,-5 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}