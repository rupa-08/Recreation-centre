using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coursework1
{
    class visitorUtility
    {
        //providing path location of file
        private static string _filePath = "visitorsList.txt";
        
        public static string WriteToText(string data)
        {
            //creating file if file does not exists in path location
            if (!File.Exists(_filePath))
            {
                using (File.Create(_filePath));
            }
            //writing inside text file using StreamWriter
            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);
            }
            return "success";

        }

        public static string ReadFromFile()
        {
            //reading data from file if file exists
            if (File.Exists(_filePath))
            {
                string str = File.ReadAllText(_filePath);
                return str;

            }
            //returning error when file does not exists in the given path
            return "File does not exists.";
        }
    }
}
