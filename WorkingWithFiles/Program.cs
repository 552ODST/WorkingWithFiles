using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WorkingWithFiles
{
    // If you need to reference the files that are used for the tests, they are located in the
    // Solution Explorer inside the folder 'TextFiles'.

    public static class WorkingWithFiles
    {
        // 1- Write a method that reads a text file and returns the number of words. Ex. The file
        // contains, "The dog ran away from home." The method should return "6" the number of words
        // contained in the file. Return "0" for the word count if the file is empty.
        // Do not forget to Trim every file.
        public static int WordCount(string fileName)
        {
            var sr = new StreamReader(fileName);
            var count = 0;
            string[] wordsInLine = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine().Trim();
                wordsInLine = line.Split(' ');
                count += wordsInLine.Length;
            }
            return count;
        }

        // 2- Write a method that reads a text file and returns the longest word in the file. Ex.
        // The file contains, "The dog named Maximus ran away from home." The method should return
        // "Maximus" the longest word contained in the file. Return "File is empty" if the file is empty.
        // Do not Trim every file.
        public static string LongestWord(string fileName)
        {
            var sr = new StreamReader(fileName);
            string[] splitLine = null;
            string line = null;
            string longestWord = "File is Empty";

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine().Trim();
                splitLine = line.Split(' ');

                for (var i = 0; i < splitLine.Length; i++)
                {
                    var firstWord = splitLine[0];

                    if (splitLine[i].Length > firstWord.Length)
                    {
                        longestWord = splitLine[i];
                    }
                    else
                    {
                        longestWord = firstWord;
                    }
                }
            }
            return longestWord;
        }
    }
    public static class Program
    {
        public static void Main()
        {
            
        }
    }
}
