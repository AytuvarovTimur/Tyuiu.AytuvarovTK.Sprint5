using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AytuvarovTK.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            // Дан файл С:\DataSprint5\InPutDataFileTask5V12.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть набор значений. Найти разницу между суммой всех положительных и отрицательных целых чисел в файле.Полученный результат вывести на консоль. У вещественных значений округлить до трёх знаков после запятой.
            string content = File.ReadAllText(path);
            string[] tokens = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double positiveSum = 0;
            double negativeSum = 0;
            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    if (number > 0 && number % 1 == 0)
                    {
                        positiveSum += number;
                    }
                    else if (number < 0 && number % 1 == 0)
                    {
                        negativeSum += number;
                    }
                }
            }
            double result = positiveSum - negativeSum;
            return Math.Round(result, 3);

        }
    }
}
