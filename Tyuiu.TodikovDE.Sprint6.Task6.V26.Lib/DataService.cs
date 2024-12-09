using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TodikovDE.Sprint6.Task6.V28.Lib
{
    public class DataService : ISprint6Task6V26
    {


        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    for (int i = 0; i < mas.Length - 1; i++)
                    {
                        resStr += mas[mas.Length - 2] + " ";
                        break;
                    }
                }
            }
            return resStr.Trim();
        }

        public string CollectTextFromFile(string str, string path)
        {
            throw new NotImplementedException();
        }
    }
}
