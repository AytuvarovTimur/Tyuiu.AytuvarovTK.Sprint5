using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AytuvarovTK.Sprint5.Task3.V11.Lib
{
    public class DataService : ISprint5Task3V11
    {
        public string SaveToFileTextData(int x)
        {
            //Дано выражение вычислить его значение при x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой. y = 4 - x^3 / x^2
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo FileInfo = new FileInfo(path);
            bool fileExists = FileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double result = 4 - System.Math.Pow(x, 3) / System.Math.Pow(x, 2);
            result = System.Math.Round(result, 3);
            using (BinaryWriter writer = new BinaryWriter(File
                    .Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }
            return path;
        }
    }
}
