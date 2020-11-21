using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Utility
{
    public class FileReader
    {
        public static IEnumerable<int> ReadNumbersFile(string filePath)
        {
            using(StreamReader myFile = new StreamReader(filePath))
            {
                var retVal = new List<int>();

                string fileData = myFile.ReadToEnd();
                var listLines = fileData.Split(' ');
                foreach(var item in listLines)
                {
                    int number;
                    if (int.TryParse(item, out number))
                        retVal.Add(number);
                }

                return retVal;
            }
        }
    }
}
