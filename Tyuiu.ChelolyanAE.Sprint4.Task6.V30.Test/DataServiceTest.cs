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
            string[] array= new string[6] { "Береза", "Дуб", "Сосна", "Пихта", "Осина", "Клён" };
            int res = ds.Calculate(array);
            int wait =
        }
    }
}