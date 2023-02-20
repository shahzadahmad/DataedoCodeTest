namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DataReader();

            //Error 2 - Referring CSV file name is not correct. 
            reader.ImportAndPrintData("data.csv");
        }
    }
}
