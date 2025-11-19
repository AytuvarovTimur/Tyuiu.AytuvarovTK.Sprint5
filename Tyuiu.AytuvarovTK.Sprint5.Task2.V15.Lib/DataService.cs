using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AytuvarovTK.Sprint5.Task2.V15.Lib
{
    public class DataService : ISprint5Task2V15
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            // Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры. Заменить нечетные элементы массива на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль. 6; 1; 7 1; 8; 5 6; 6; 4
            string path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo FileInfo = new FileInfo(path);
            bool exists = FileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                    line += matrix[i, j].ToString();
                    if (j < cols - 1)
                    {
                        line += ";";
                    }
                }
                File.AppendAllText(path, line + "\n");
            }
            return path;


        }
    }
}
