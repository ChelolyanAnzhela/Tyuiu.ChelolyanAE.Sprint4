using Tyuiu.ChelolyanAE.Sprint4.Task3.V12.Lib;
namespace Tyuiu.ChelolyanAE.Sprint4.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds=new DataService();
            int[,] array = new int[5, 5] { { 9, 7, 4, 9, 7 }, { 5, 2, 5, 7, 6 }, { 8, 3, 3, 5, 7 }, { 8, 4, 2, 4, 5 }, { 8, 8, 9, 5, 6 } };
            int res =ds.Calculate(array);
            int wait = 2;
            Assert.AreEqual(wait,res);
        }
    }
}