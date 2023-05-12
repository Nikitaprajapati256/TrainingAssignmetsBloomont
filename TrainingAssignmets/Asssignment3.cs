using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAssignmets
{
    public class Asssignment3
    {//1.
        public void LimitDigit()
        {
            
            Console.Write("Enter the lower limit: ");
            int lowerLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper limit: ");
            int upperLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter the single digit: ");
            int digit = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Series of numbers with given digit");

            for (int number = lowerLimit; number <= upperLimit; number++)
            {
                if (number.ToString().Contains(digit.ToString()))
                {
                    Console.Write(number + ",");
                }
            }

            Console.WriteLine();
        }
        //2.
        public void FirstLetterUpperCase() 
        {
           
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

           
            string[] words = sentence.Split(' ');

           
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    char[] letters = words[i].ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    words[i] = new string(letters);
                }
            }

           
            string result = string.Join(" ", words);

           
            Console.WriteLine(result);
        }


        //3. 



        public static void PrintFolderProperties()
        {
            try
            {
                Console.WriteLine("Enter the Folder path");
                string folderPath = Console.ReadLine();
                DirectoryInfo directory = new DirectoryInfo(folderPath);

                if (directory.Exists)
                {
                    long totalSize = GetDirectorySize(directory);
                    int totalFiles = GetTotalFiles(directory);
                    int totalFolders = GetTotalFolders(directory);
                    int maxDepth = GetMaxDepth(directory);

                    string sizeString = GetSizeString(totalSize);

                    Console.WriteLine("Name: " + directory.Name);
                    Console.WriteLine("Full Path: " + directory.FullName);
                    Console.WriteLine("Total Size: " + sizeString);
                    Console.WriteLine("Total files: " + totalFiles);
                    Console.WriteLine("Total folders: " + totalFolders);
                    Console.WriteLine("Max depth: " + maxDepth);
                }
                else
                {
                    Console.WriteLine("Folder does not exist.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid path");
                PrintFolderProperties();
            }
        }

        public static long GetDirectorySize(DirectoryInfo directory)
        {
            long totalSize = 0;

            foreach (FileInfo file in directory.GetFiles())
            {
                totalSize += file.Length;
            }

            foreach (DirectoryInfo subDir in directory.GetDirectories())
            {
                totalSize += GetDirectorySize(subDir);
            }

            return totalSize;
        }

        public static int GetTotalFiles(DirectoryInfo directory)
        {
            int totalFiles = directory.GetFiles().Length;

            foreach (DirectoryInfo subDir in directory.GetDirectories())
            {
                totalFiles += GetTotalFiles(subDir);
            }

            return totalFiles;
        }

        public static int GetTotalFolders(DirectoryInfo directory)
        {
            int totalFolders = directory.GetDirectories().Length;

            foreach (DirectoryInfo subDir in directory.GetDirectories())
            {
                totalFolders += GetTotalFolders(subDir);
            }

            return totalFolders;
        }

        public static int GetMaxDepth(DirectoryInfo directory)
        {
            int maxDepth = 0;

            foreach (DirectoryInfo subDir in directory.GetDirectories())
            {
                int depth = GetMaxDepth(subDir);
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }

            return maxDepth + 1;
        }

        public static string GetSizeString(long size)
        {
            const int kb = 1024;
            const int mb = kb * 1024;
            const int gb = mb * 1024;

            if (size < kb)
            {
                return size.ToString() + " B";
            }
            else if (size < mb)
            {
                return (size / kb).ToString() + " KB";
            }
            else if (size < gb)
            {
                return (size / mb).ToString() + " MB";
            }
            else
            {
                return (size / gb).ToString() + " GB";
            }
        }










    }
}
