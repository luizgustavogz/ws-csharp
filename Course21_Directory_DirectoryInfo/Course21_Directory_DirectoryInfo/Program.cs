using System;
using System.IO;
using System.Collections.Generic;

namespace Course21_Directory_DirectoryInfo {
    class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\folder";

            try {
                /* IEnumerable<string> or var */
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFILES: ");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred\n " + e.Message);
            }
        }
    }
}
