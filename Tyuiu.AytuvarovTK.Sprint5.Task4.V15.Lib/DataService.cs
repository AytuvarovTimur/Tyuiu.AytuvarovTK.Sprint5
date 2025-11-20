using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AytuvarovTK.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            // Дан файл С:\DataSprint5\InPutDataFileTask4V0.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть вещественное значение. Прочитать значение из файла и подставить вместо Х в формуле y = sin(x) + x^2 / 2 Вычислить значение по формуле (Полученное значение округлить до трёх знаков после запятой) и вернуть полученный результат на консоль.
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double y = Math.Sin(x) + (x * x) / 2;
            return Math.Round(y, 3);
        }
    }
}
