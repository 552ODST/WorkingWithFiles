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
        // .Trim() might be useful in this situation.
        public static int WordCount(string fileName)
        {
            int result = 0;
            string line = "";
            string[] words;
            if (File.Exists(fileName))
            {
                string[] content = File.ReadAllLines(fileName);
                if (content.Length == 0)
                {
                    return result;
                }
                else
                {
                    for (int i = 0; i < content.Length; i++)
                    {
                        line = content[i].Trim();
                        words = line.Split(" .,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        result += words.Count();
                    }
                }
            }
            return result;
        }

        // 2- Write a method that reads a text file and returns the longest word in the file. Ex.
        // The file contains, "The dog named Maximus ran away from home." The method should return
        // "Maximus" the longest word contained in the file. Return "File is Empty" if the file is empty.
        // .Trim() might be useful in this situation.
        public static string LongestWord(string fileName)
        {
            string result = "";
            string line = "";
            string[] words;
            if (File.Exists(fileName))
            {
                string[] content = File.ReadAllLines(fileName);
                if (content.Length == 0)
                {
                    return "File is Empty";
                }
                else
                {
                    for (int i = 0; i < content.Length; i++)
                    {
                        line = content[i].Trim();
                        words = line.Split(" .,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < words.Length; j++)
                        {
                            if (words[j].Length > result.Length)
                            {
                                result = words[j];
                            }
                        }
                    }
                }
            }
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
