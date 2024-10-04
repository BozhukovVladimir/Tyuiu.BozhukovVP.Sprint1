using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BozhukovVP.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - y / (x + Math.Pow(x, 2) / y))));
            double zet = Math.Round(z, 3);
            return zet;
        }
    }
}
