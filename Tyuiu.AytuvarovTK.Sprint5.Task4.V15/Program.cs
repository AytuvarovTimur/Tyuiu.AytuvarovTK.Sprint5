using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvarovTK.Sprint5.Task4.V15.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask4V15.txt";
            double result = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}
