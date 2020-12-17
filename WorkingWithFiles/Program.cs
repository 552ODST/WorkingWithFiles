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
            var streamReader = new StreamReader(fileName);
            var count = 0;
            string[] words = null;
            string sentence = null;

            while (!streamReader.EndOfStream)
            {
                sentence = streamReader.ReadLine().Trim();
                words = sentence.Split(' ');
                count += words.Length;
            }
            return count;
        }
        // 2- Write a method that reads a text file and returns the longest word in the file. Ex.
        // The file contains, "The dog named Maximus ran away from home." The method should return
        // "Maximus" the longest word contained in the file. Return "File is Empty" if the file is empty.
        // .Trim() might be useful in this situation.
        public static string LongestWord(string fileName)
        {
            var streamReader = new StreamReader(fileName);
            string[] words = null;
            string sentence = null;
            string longestWord = "File is Empty";

            while (!streamReader.EndOfStream)
            {
                sentence = streamReader.ReadLine().Trim();
                words = sentence.Split(' ');

                var beginning = words[0];
                for (var i = 0; i < words.Length; i++)
                {


                    if (words[i].Length > beginning.Length)
                    {
                        longestWord = words[i];

                    }
                    else
                    {
                        longestWord = beginning;
                    }
                }

                string Longestword = beginning;

                while (!streamReader.EndOfStream)
                {
                    sentence = streamReader.ReadLine().Trim();
                    words = sentence.Split(' ');
                    Longestword += words.Length;
                    var i = 0;
                    if (words[i].Length != beginning.Length)

                    return words[i];
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
