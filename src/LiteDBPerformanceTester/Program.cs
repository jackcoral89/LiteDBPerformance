﻿using System;

namespace LiteDBPerformanceTester
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTest("LiteDB: default", new LiteDBTest(5000, string.Empty));
            RunTest("LiteDB: encrypted", new LiteDBTest(5000, "pa44w0rd"));
            
            Console.ReadKey();
        }

        static void RunTest(string name, ILiteDBTest test)
        {
            var title = name + " - " + test.Count + " records";
            Console.WriteLine(title);
            Console.WriteLine("=".PadLeft(title.Length, '='));

            test.Prepare();

            test.Run("Insert", test.Insert);
            test.Run("Bulk", test.Bulk);
            test.Run("Update", test.Update);
            test.Run("CreateIndex", test.CreateIndex);
            test.Run("Query", test.Query);
            test.Run("Delete", test.Delete);
            test.Run("Drop", test.Drop);

            Console.WriteLine("File Size : " + Math.Round((double)test.FileLength / (double)1024, 2).ToString().PadLeft(5, ' ') + " kb");

            test.Dispose();

            Console.WriteLine();
        }
    }
}
