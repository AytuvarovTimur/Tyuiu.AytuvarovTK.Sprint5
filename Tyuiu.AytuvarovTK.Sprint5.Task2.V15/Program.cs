using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvarovTK.Sprint5.Task2.V15.Lib;

namespace Tyuiu.AytuvarovTK.Sprint5.Task2.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 6, 1, 7 },
                { 1, 8, 5 },
                { 6, 6, 4 }
            };

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            string path = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Результат сохранён в файл: " + path);

            Console.ReadKey();

        }
    }
}
