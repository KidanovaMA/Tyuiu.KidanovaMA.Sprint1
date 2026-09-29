using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KidanovaMA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] words = value.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                if (word.Length % 2 != 0)
                {
                    int mid = word.Length / 2;
                    result += word.Remove(mid, 1) + " ";
                }
                else
                {
                    result += word + " ";
                }
            }
            return result.Trim();
        }
    }
}
