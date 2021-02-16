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
            //would have to look out for the proper file location of filename, if wrong then it would cause an exception
            var sr = new StreamReader(fileName);
            var count = 0;
            string[] wordsInLine = null;
            string line = null;

            // while we are not at the end of the stream
            while (!sr.EndOfStream)
            {
                // read each line and trim it
                line = sr.ReadLine().Trim();

                // split the line of words into an array of words
                wordsInLine = line.Split(' ');

                // add the length of that array into count
                count += wordsInLine.Length;

                // this process repeats until the end of the stream
            }
            // returns 0 if the while loop never entered, otherwise returns length of wordsInLine
            return count;
        }
        // 2- Write a method that reads a text file and returns the longest word in the file. Ex.
        // The file contains, "The dog named Maximus ran away from home." The method should return
        // "Maximus" the longest word contained in the file. Return "File is empty" if the file is empty.
        // Do not Trim every file.
        public static string LongestWord(string fileName)
        {
            //creating variables
            var sr = new StreamReader(fileName);
            string[] splitLine = null;
            string line = null;
            string longestWord = string.Empty;

            // while we are not at the end of the stream
            while (!sr.EndOfStream)
            {
                // reads every line and trims them to not confuse the .split
                line = sr.ReadLine().Trim();

                // splits each line by their spaces and different words into a string array 
                splitLine = line.Split(' ');

                // sorts the string array by length of the word in ascending order
                var sorted = splitLine.OrderBy(n => n.Length);

                // takes the last index of the array
                // as long as it's longer than the current sorted last
                if (sorted.LastOrDefault().Length > longestWord.Length)
                {
                    // if the longestword is not longer then we set the sorted word to be the new longest
                    longestWord = sorted.LastOrDefault();
                }
            }
            // if longestWord is empty we return "File is Empty" otherwise we return the longest word
            return (longestWord == string.Empty) ? "File is Empty" : longestWord;
        }
        public static class Program
        {
        }
        public static void Main()
        {
            Console.WriteLine(WorkingWithFiles.LongestWord("WordCounter.txt"));
        }
    }
}
