using System;
using System.IO;

namespace working_with_file
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDemo();
        }

        private static void FileDemo()
        {
            string path = "Hello.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Hello World!");
            }
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
