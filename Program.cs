using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileInput = "125,1,2";
            //string multipleInput = "358, 32";
            string dataRecov = ("programming first The language;3 2 1");
            TestClass test = new TestClass();
            //test.MultipleCompare(multipleInput);
            //test.MultiplicationTable(12);
            //test.LowerCase("Eqpu'pg%UnT!jo)7V}u5RF*~~-L_2dYV4");
            test.DataRecovery(dataRecov);

            string filePath = "C:/Users/Marc/Documents/Visual Studio 2015/Projects/CodeEval/input.txt";
            StreamReader reader = File.OpenText(filePath);
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
            }
        }
    }
}
