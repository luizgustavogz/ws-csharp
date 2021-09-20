using System;
using System.IO;

namespace Course18_File_FileInfo {
    class Program {
        static void Main(string[] args) {

            string sourcePath = @"c:\temp\file.txt";
            string targetPath = @"c:\temp\file1.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines) {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred\n" + e.Message);
            }
        }
    }
}
