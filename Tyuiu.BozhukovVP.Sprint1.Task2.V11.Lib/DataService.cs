using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BozhukovVP.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public int ConvertHoursMinutesToSeconds(int hour, int minute)
        {
            return 60 * (hour * 60 + minute);
        }
    }
}
