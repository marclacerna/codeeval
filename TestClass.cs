using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval
{
    class TestClass
    {
        public void BitConvert(string line)
        {
            string[] subStr = line.Split(',');
            string result = "";
            //PrintTest(subStr);
            int value, pos1, pos2;

            Int32.TryParse(subStr[0], out value);
            Int32.TryParse(subStr[1], out pos1);
            Int32.TryParse(subStr[2], out pos2);

            pos1 -= 1;
            pos2 -= 1;

            if (((value >> pos1) & 1) == ((value >> pos2) & 1))
            {
                result = "true";
            }
            else
            {
                result = "false";
            }

            Console.WriteLine(result);
        }
        private void PrintTest(string[] subStr)
        {
            foreach(var x in  subStr)
            {
                Console.WriteLine(x);
            }

        }

        // multiples of a number
        public void MultipleCompare(string line)
        {
            string[] subStr = line.Split(',');
            int x, n;
            Int32.TryParse(subStr[0], out x);
            Int32.TryParse(subStr[1], out n);

            int index = n;
            while(n < x)
            {
                n += index;
            }
            Console.WriteLine(n);
        }
        public void MultiplicationTable(int value)
        {
            for (int i = 1; i <= value; i++)
            {                
                for (int j = 1; j <= value; j++)
                {
                    //product[j - 1] = (i * j).ToString();
                    Console.Write("{0,4}", (i * j));
                }
                Console.WriteLine();
            }
        }

        public void LowerCase(string line)
        {
            Console.WriteLine(line.ToLower());
        }

        public void DataRecovery(string line)
        {
            string[] subStr = line.Split(';');
            Dictionary<string,string> wordsList = new Dictionary<string , string >();

            wordsList.Add(subStr[1], subStr[0]);
        }

        public void LongestLines(string line)
        {

        }


    }
}
