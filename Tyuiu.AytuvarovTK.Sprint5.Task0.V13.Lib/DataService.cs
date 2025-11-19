using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AytuvarovTK.Sprint5.Task0.V13.Lib
{
    public class DataService : ISprint5Task0V13
    {
        public string SaveToFileTextData(int x)
        {
            // Дано выражение f(x) = - 1.4*x^3 + 2.3*x^2+0.6*x вычислить его значение при x = 5, результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков после запятой.
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double result = -1.4 * System.Math.Pow(x, 3) + 2.3 * System.Math.Pow(x, 2) + 0.6 * x;
            result = System.Math.Round(result, 3);
            File.WriteAllText(path, result.ToString());
            return path;
        }
    }
}
