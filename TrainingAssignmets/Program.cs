using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingAssignmets
{
    internal class Program
    {
        static void Main(string[] args)
        {






        Start:
            Assignment1 assignment1 = new Assignment1();
            Assignment2 assignment2 = new Assignment2();
            Asssignment3 asssignment3 = new Asssignment3();


            char z, ch,z1,z2;
            do
            {
                Console.WriteLine("Select option ");
                Console.WriteLine("1.Assignment 1");
                Console.WriteLine("2.Assignment 2");
                Console.WriteLine("3.Assignment 3");
                Console.WriteLine("4.Assignment 4");
                Console.WriteLine("exit 0");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case (int)ModuleEnum.AssName.Exit:
                        Environment.Exit(0);
                        break;

                    case (int)ModuleEnum.AssName.Assignment1:

                        do
                        {
                            Console.WriteLine("1.Palidrome Program");
                            Console.WriteLine("2.Nth prime Number ");
                            Console.WriteLine("3.Nth Fibonacci number");
                            Console.WriteLine("4.factorial of Nth number");
                            Console.WriteLine("5.Nth number Pattern");
                            Console.WriteLine("6.Exit");
                            Console.WriteLine("select any option ");
                            int op = Convert.ToInt32(Console.ReadLine());

                            switch (op)
                            {
                                case 1:
                                    assignment1.Palindrome();
                                    break;

                                case 2:
                                    Console.WriteLine(" Enter any Number");
                                    int inum = Convert.ToInt32(Console.ReadLine());
                                    assignment1.FindprimeNumber(inum);
                                    Console.WriteLine("nth fibonacci number is :" + assignment1.fibonaci(inum));
                                    Console.WriteLine("Nth factorial of number is : " + assignment1.factorial(inum));

                                    break;
                                case 5:
                                    assignment1.Pattern();
                                    break;
                                case 6: goto Start;

                                default:
                                    Console.WriteLine("Option not available");
                                    break;
                            }
                            Console.WriteLine("do u want to continue y or n ?");
                            z = Convert.ToChar(Console.ReadLine());

                        } while (z == 'y' || z != 'n');

                        break;

                    case (int)ModuleEnum.AssName.Assignment2:

                        do
                        {
                            Console.WriteLine("1.Array Problem for dublicate and matrix");
                            Console.WriteLine("2.Star patter");
                            Console.WriteLine("3.Exit");

                            int Iopt = Convert.ToInt32(Console.ReadLine());
                            switch (Iopt)
                            {
                                case 1:
                                    assignment2.ArrayProblem1();
                                    break;
                                case 2: assignment2.StarPatter();
                                    break;
                                case 3: goto Start;

                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }
                            Console.WriteLine("do u want to continue y or n ?");
                            z1 = Convert.ToChar(Console.ReadLine());
                        } while (z1 == 'y' || z1 != 'n');

                        break;

                    case (int)ModuleEnum.AssName.Assignment3:
                        
                        do
                        {
                            Console.WriteLine("1.Program to print Series of numbers with given digit and Limits");
                            Console.WriteLine("2.Print First Letter of Word in Upper Case");
                            Console.WriteLine("3.File Folder");
                            Console.WriteLine("4.Exit");
                            int opt1 = Convert.ToInt32(Console.ReadLine());
                            switch (opt1)
                            {
                                case 1: asssignment3.LimitDigit();
                                    break;
                                case 2:
                                    asssignment3.FirstLetterUpperCase();
                                    break;
                                case 3:
                                    Asssignment3.PrintFolderProperties();
                                    break;
                                case 4: goto Start;

                                default:
                                    Console.WriteLine("Invalid option selection");
                                    break;
                            }
                            Console.WriteLine("Do you want to continue y or n?");
                            z2 = Convert.ToChar(Console.ReadLine());

                        } while (z2 == 'y'|| z2!='n');
                        break;

                    default:
                        Console.WriteLine("Invalid Option Selection");
                        break;
                }

                Console.WriteLine("do u want to continue y or n ?");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch != 'n');


        }
    }
}
