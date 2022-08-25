using System;
using System.Collections.Generic;


namespace DataStructurePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Programs!");

            string inputFilePath = @"H:\All Asignment\Assignment16&17\DataStructures\DataStructurePrograms\DataStructurePrograms\InputFile.txt";
            string outputFilePath = @"H:\All Asignment\Assignment16&17\DataStructures\DataStructurePrograms\DataStructurePrograms\OutputFile.txt";
            new UnOrderedList().UnorderListOperations(inputFilePath, outputFilePath);
        }
    }
}
