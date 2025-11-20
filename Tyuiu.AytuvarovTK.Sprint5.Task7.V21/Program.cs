using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvarovTK.Sprint5.Task7.V21.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string inputPath = @"C:\DataSprint5\InputDataFileTask7V21.txt";

            string tempDirectory = Path.GetTempPath();
            string tempFileName = Path.GetFileName(inputPath);
            string tempFilePath = Path.Combine(tempDirectory, tempFileName);

            File.Copy(inputPath, tempFilePath, true);

            Console.WriteLine($"Файл скопирован в: {tempFilePath}");

            string result = ds.LoadDataAndSave(tempFilePath);

            string outputPath = Path.Combine(tempDirectory, "OutPutDataFileTask7V21.txt");
            File.WriteAllText(outputPath, result);

            Console.WriteLine($"Результат сохранён в: {outputPath}");
            Console.WriteLine("Содержимое результата:");
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
