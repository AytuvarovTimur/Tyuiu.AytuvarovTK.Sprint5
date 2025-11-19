using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvarovTK.Sprint5.Task1.V4.Lib;

namespace Tyuiu.AytuvarovTK.Sprint5.Task1.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Табулирование функции F(x) на диапазоне [" + startValue + "; " + stopValue + "] с шагом 1:");
            string path = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Результат сохранён в файл: " + path);

            Console.ReadKey();

        }
    }
}
