using Tyuiu.BozhukovVP.Sprint1.Task0.V27.Lib;
namespace Tyuiu.BozhukovVP.Sprint1.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(22, res);
        }
    }
}
