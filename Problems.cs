using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval
{
    class Problems
    {
        public void LongestLine(string filePath)
        {
            StreamReader reader = File.OpenText(filePath);
            Dictionary<string, int> strSet = new Dictionary<string, int>();
            int count = 0;
            int loopDisplay = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Length == 0)
                    continue;

                if(count == 0)
                {
                    System.Int32.TryParse(line, out loopDisplay);
                    Console.WriteLine("value => {0}", loopDisplay);     
                }
                else
                {
                    strSet.Add(line, line.Length);
                }
                count += 1;             
            }

            int temp = 0;
            foreach (var i in strSet.OrderByDescending(index => index.Value))
            {
                if (temp < loopDisplay)
                {
                    Console.WriteLine(i.Key);
                    temp += 1;
                }
                else
                {
                    break;
                }
            }
        }
        public void Lower(string filePath)
        {
            using (StreamReader reader = File.OpenText(filePath))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    Console.WriteLine(line.ToLower());
                }
        }
        #region Data Recovery
        public void DataRecovery(string filePath)
        {
            StreamReader reader = File.OpenText(filePath);
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Length == 0)
                    continue;

                string[] subStr = line.Split(';');
            }
        }

        private void RearrangeLines(string[] strArr)
        {
            Dictionary<int, string> dataSet = new Dictionary<int, string>();
            string[] textData = strArr[0].Split(' ');
            string[] indexData = strArr[1].Split(' ');
            int index = 0;

            for(int i = 0; i < textData.Length; i++)
            {
                if(i != textData.Length - 1)
                {
                    System.Int32.TryParse(indexData[i], out index);
                    dataSet.Add(index, textData[i]);
                }
                else
                {
                    dataSet.Add(i, textData[i]);
                }                
            }
        }
        #endregion
    }
}
s