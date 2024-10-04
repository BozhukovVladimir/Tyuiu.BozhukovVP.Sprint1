using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BozhukovVP.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string[] words = value.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' },
            StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (string word in words)
            {
                result += word[word.Length - 1];
            }

            return result;
        }
    }
}
