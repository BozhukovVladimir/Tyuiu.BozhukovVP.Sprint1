using Tyuiu.BozhukovVP.Sprint1.Task4.V9.Lib;
namespace Tyuiu.BozhukovVP.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-5.872, res);
        }
    }
}
