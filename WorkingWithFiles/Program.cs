using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WorkingWithFiles
{
    public static class WorkingWithFiles
    {
        // 1- Write a method that reads a text file and returns the number of words. Ex. The file
        // contains, "The dog ran away from home." The method should return "6" the number of words
        // contained in the file. Return "0" for the word count if the file is empty.
        // Do not forget to Trim every file.
        public static int WordCount(string fileName)
        {
            var result = 0;
            string filePath = Path.Combine(Directory.GetCurrentDirectory().ToString(), "TextFiles", fileName);
            var countFile = File.ReadAllLines(filePath);

            foreach (var item in countFile)
            {
                var number = item.Trim().Split(" ").Length;
                result += number;
            }

            return result;
        }

        // 2- Write a method that reads a text file and returns the longest word in the file. Ex.
        // The file contains, "The dog named Maximus ran away from home." The method should return
        // "Maximus" the longest word contained in the file. Return "File is empty" if the file is empty.
        // Do not Trim every file.
        public static string LongestWord(string fileName)
        {
            string result = "File is Empty";
            string filePath = Path.Combine(Directory.GetCurrentDirectory().ToString(), "TextFiles", fileName);
            var countFile = File.ReadAllLines(filePath);
            var AllTheWords = new string[0];

            if (countFile.Length == 0)
            {
                return result;
            }

            foreach (var item in countFile)
            {
                AllTheWords = item.Trim().Split(" ");
            }

            result = AllTheWords[0];

            for (var i = 0; i < AllTheWords.Length; i++)
            {
                if (AllTheWords[i].Length > result.Length)
                {
                    result = AllTheWords[i];
                }
            }
            // Delete the below line when you are writing your code 
            return result;
        }
    }

    public static class Program
    {
        public static void Main()
        {

        }
    }
}
