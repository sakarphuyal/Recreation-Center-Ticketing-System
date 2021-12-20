using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{
    static class Utils
    {
        public static void setOnFile(string data, string fileName) {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

            File.AppendAllText(fileName, data+"\n");
        }
    }
}
