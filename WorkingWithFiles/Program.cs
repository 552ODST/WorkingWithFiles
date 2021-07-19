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
            List<string> words = new List<string>();

            string path = @"C:\Users\SSgt Cooper\Documents\GitHub\WorkingWithFiles\WorkingWithFilesTest";
            string line;
            int count = 0;
            
            using (StreamReader file = new StreamReader(new FileStream(Path.Combine(path, fileName) , FileMode.Open)))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        words.AddRange(line.Trim().Split(' '));
                    }
                    count += words.Count;
                }

            return count;
        }

        // 2- Write a method that reads a text file and returns the longest word in the file. Ex.
        // The file contains, "The dog named Maximus ran away from home." The method should return
        // "Maximus" the longest word contained in the file. Return "File is Empty" if the file is empty.
        // .Trim() might be useful in this situation.
        public static string LongestWord(string fileName)
        {
            List<string> words = new List<string>();

            string path = @"C:\Users\SSgt Cooper\Documents\GitHub\WorkingWithFiles\WorkingWithFilesTest";
            string line;
            string longest;
            
            using (StreamReader file = new StreamReader(new FileStream(Path.Combine(path, fileName), FileMode.Open)))
            {
                if (file.Peek() < 0)
                {
                    longest = "File is Empty";
                }
                else
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        words.AddRange(line.Trim().Split(' '));
                    }
                    longest = words.OrderByDescending(n => n.Length).First();
                }
            }
            return longest;
        }
    }

    public static class Program
    {
        public static void Main()
        {
            
        }
    }
}
