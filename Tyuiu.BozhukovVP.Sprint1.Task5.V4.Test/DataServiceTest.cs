using Tyuiu.BozhukovVP.Sprint1.Task5.V4.Lib;
namespace Tyuiu.BozhukovVP.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            DataService ds = new DataService();
            int time = 13257;
            int res = ds.SecondsToHours(time);
            int result = Convert.ToInt32(res);
            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
