using Tyuiu.ChelolyanAE.Sprint4.Task6.V30.Lib;
namespace Tyuiu.ChelolyanAE.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var name= new string[] { "Береза", "Дуб", "Сосна", "Пихта", "Осина", "Клён" };
            string[] res = ds.Calculate(name);
            string[] wait = { "Береза" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}