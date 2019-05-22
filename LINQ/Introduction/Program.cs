using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Introduction
{
    //Shows the n largest files in a given directory
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"H:\02_Private\BOOKs\C#\C#_OOP_Basics";
            ShowFilesWithoutLinq(path);
            Console.WriteLine("=====");
            ShowFilesWithLinq(path);
        }

        private static void ShowFilesWithLinq(string path)
        {
            //var query = from file in new DirectoryInfo(path).GetFiles()
            //            orderby file.Length descending
            //            select file;

            var query = new DirectoryInfo(path).GetFiles()
                .OrderByDescending(f => f.Length)
                .Take(5);

            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name,-55} : {file.Length,10:N0}");
            }
        }

        private static void ShowFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());
            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name, -55} : {file.Length, 10:N0}");
            }
        }

        public class FileInfoComparer : IComparer<FileInfo>
        {
            public int Compare(FileInfo x, FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }
    }
}
