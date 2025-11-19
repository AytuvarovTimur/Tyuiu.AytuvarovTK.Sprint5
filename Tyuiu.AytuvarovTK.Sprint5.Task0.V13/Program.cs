using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvarovTK.Sprint5.Task0.V13.Lib;

namespace Tyuiu.AytuvarovTK.Sprint5.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5;
            Console.WriteLine("x = " + x);
            string path = ds.SaveToFileTextData(x);
            Console.WriteLine("Результат сохранён в файл: " + path);

            Console.ReadKey();

        }
    }
}
