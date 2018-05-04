using System;
using System.IO;

namespace working_with_file
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDemo();
            string fileName = "Demo.txt";
            string folderName = "Hello World";
            Directory.CreateDirectory(folderName);
            File.Copy("Hello.txt", folderName+"//"+fileName, true);
            string path = folderName+"//"+fileName;
            System.Console.WriteLine("File Name: "+Path.GetFileName(path));
            System.Console.WriteLine("Extension Name: "+Path.GetExtension(path));
            System.Console.WriteLine("Directory Name: "+Path.GetDirectoryName(path));
        }

        private static void FileDemo(string fileName = "Hello.txt")
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine("Hello World!");
            }
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            //File.Delete(fileName);
        }
    }
}
