using Tyuiu.BozhukovVP.Sprint1.Task7.V4.Lib;
namespace Tyuiu.BozhukovVP.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = -1.099;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}