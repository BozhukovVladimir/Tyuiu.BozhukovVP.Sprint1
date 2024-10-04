using Tyuiu.BozhukovVP.Sprint1.Task2.V11.Lib;
namespace Tyuiu.BozhukovVP.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int hour = 2;
            int minute = 3;
            var res = ds.ConvertHoursMinutesToSeconds(hour, minute);
            Assert.AreEqual(7380, res);
        }
    }
}