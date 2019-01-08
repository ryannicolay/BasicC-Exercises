using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Ryan\Desktop\DatabaseFirstCheatSheet.txt";

            File.OpenText(path);
        }
    }
}
