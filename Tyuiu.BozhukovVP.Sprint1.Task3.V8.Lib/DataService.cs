using System.Xml.Schema;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BozhukovVP.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            double doh = ((percent / 100 * startAmount) / 365) * timeDays;
            double x = startAmount + doh;
            double xot = Math.Round(x, 3);
            return xot;
        }
    }
}

