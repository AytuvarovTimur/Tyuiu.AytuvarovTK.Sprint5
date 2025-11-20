using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AytuvarovTK.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            //Дан файл С:\DataSprint5\InPutDataFileTask7V21.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть набор символьных данных.Удалить все знаки препинания из файла.Полученный результат сохранить в файл OutPutDataFileTask7V21.txt.
            string content = File.ReadAllText(path);
            string pattern = @"[.,!?;:""'\-–—()\[\]{}]";
            string result = Regex.Replace(content, pattern, string.Empty);
            return result;

        }
    }
}
