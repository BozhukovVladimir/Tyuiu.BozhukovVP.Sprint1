using Tyuiu.BozhukovVP.Sprint1.Task6.V3.Lib;
namespace Tyuiu.BozhukovVP.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "� ����� �� ������";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);

            Assert.AreEqual("����", res);
        }
    }
}