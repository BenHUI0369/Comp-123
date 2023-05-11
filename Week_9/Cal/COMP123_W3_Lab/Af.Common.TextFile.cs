using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Af.Common
{
    class AfTextFile
    {
        public static string Read(string filePath, Encoding encoding)
        {
            using(StreamReader sr = new StreamReader(filePath, encoding))
            {
                return sr.ReadToEnd();
            }
        }

        public static void Write(string filePath, string content, Encoding encoding)
        {
            using(StreamWriter sw = new StreamWriter(filePath))
            {

            }
        }
    }
}
