using Tyuiu.ChelolyanAE.Sprint4.Task2.V25.Lib;

namespace Tyuiu.ChelolyanAE.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 3, 4, 5, 6, 7, 8, 9, 8, 6, 5, 7 };
            int res =ds.Calculate(array);
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}