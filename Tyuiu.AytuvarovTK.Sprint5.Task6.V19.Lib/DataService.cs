using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AytuvarovTK.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            // Дан файл С:\DataSprint5\InPutDataFileTask6V19.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть набор символьных данных.Найти количество двузначных чисел в заданной строке.
            string content = File.ReadAllText(path);
            int count = 0;
            string[] tokens = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string token in tokens)
            {
                if (int.TryParse(token, out int number))
                {
                    if (number >= 10 && number <= 99 || number <= -10 && number >= -99)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
