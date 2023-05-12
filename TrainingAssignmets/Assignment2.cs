using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static TrainingAssignmets.ModuleEnum;
using static TrainingAssignmets.ModuleEnum.AssName;

namespace TrainingAssignmets
{
    public class Assignment2
    {
        //Write a program interactive program that will read the data for array and following operations
        //a) find the duplicate items in both string and integer array.
            public void ArrayProblem1()
             {
            char ch1;
            do
            {

                Console.WriteLine("1.Find Duplicates for Number");
                Console.WriteLine("2.Find Duplicates for String");
                Console.WriteLine("3.90 degree Matrix rotate");
                Console.WriteLine("4.Exit");
                int op1=Convert.ToInt32(Console.ReadLine());
                switch(op1)
                {
                    case 1:
                        Console.WriteLine("Enter the size of array elements");
                        int n=Convert.ToInt32(Console.ReadLine());
                        int[] array = new int[n];
                        Console.WriteLine("Enter Array Elemets");
                        for (int index = 0; index < array.Length; index++)
                        {
                            array[index] = Convert.ToInt32(Console.ReadLine());
                        }
                       
                        Console.WriteLine("Duplicate elements of an array :");
                        for (int index = 0; index < array.Length; index++)
                        {
                            for (int index2 = index + 1; index2 < array.Length; index2++)
                            {
                                if (array[index] == array[index2])
                                {
                                    Console.WriteLine(array[index2]);
                                }
                            }
                        }
                        break;
                        case 2:
                        try
                        {
                            Console.WriteLine("Enter the size of string array");
                            int In = Convert.ToInt32(Console.ReadLine());
                            string[] sstrArray = new string[In];

                            Console.WriteLine("Enter the String to check duplicates");
                            for (int i = 0; i < sstrArray.Length; i++)
                            {
                                sstrArray[i] = Console.ReadLine();
                            }
                            Console.WriteLine("Duplicate strings");
                            for (int index = 0; index < sstrArray.Length; index++)
                            {
                                for (int index2 = index + 1; index2 < sstrArray.Length; index2++)
                                {
                                    if ((sstrArray[index].Equals(sstrArray[index2])) && (index != index2))
                                    {
                                        Console.WriteLine(sstrArray[index2]);
                                    }
                                }
                            }
                            break;
                        }catch(Exception ex)
                        {
                            Console.WriteLine("Invalid Entry");
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case 3:

                        //b)print the 90 degree of input integer 2d n*n array
                        Console.WriteLine("Enter size of matrix nxn ");
                        int n1=Convert.ToInt32 (Console.ReadLine());
                        int[,] matrix = new int[n1, n1];
                            Console.WriteLine("Enter matrix elements:");

                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("c90 degree rotate matrix");
                            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                            {
                                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                                {
                                    Console.Write(matrix[j, i]);
                                }
                                Console.WriteLine();
                            }
                        
                        break;
                        case 4:
                        break;
                      
                      
                        default: Console.WriteLine("Invalid option ");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                ch1 =Convert.ToChar(Console.ReadLine());
            } while (ch1 == 'y'||ch1!='n');
            
           

            }
       

            //2. Pyramid star pattern

        public void StarPatter()
        {
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n - 1;

       
            Console.WriteLine(new string('-', width + 2));

        
            for (int i = 0; i < n; i++)
            {
                Console.Write('|');

                
                Console.Write(new string(' ', n - i - 1));

              
                Console.Write(new string('*', 2 * i + 1));

                Console.Write(new string(' ', n - i - 1));

                
                Console.WriteLine('|');
            }

          
            Console.WriteLine(new string('-', width + 2));
        }
    





    }
}
