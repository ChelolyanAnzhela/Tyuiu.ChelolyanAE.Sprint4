using Tyuiu.ChelolyanAE.Sprint4.Task1.V21.Lib;
namespace Tyuiu.ChelolyanAE.Sprint4.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };
            int res = ds.Calculate(array);
            int wait = 1769472;
            Assert.AreEqual(wait,res);
        }
    }
}