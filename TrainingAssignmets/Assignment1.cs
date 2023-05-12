using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAssignmets
{
    public class Assignment1
    {
        public void Palindrome()
        {
            char ch;
            do
            {
                Console.WriteLine("Select Text or Number");
                Console.WriteLine("1.Checked Text Palindrome");
                Console.WriteLine("2.Checked Number Palindrome");
                Console.WriteLine("3.Go to Main Menu");
                int opt=Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {
                    case 1:
                        Console.WriteLine("Enter Any string ");
                        string sStr=Console.ReadLine();
                        string sreverse = string.Empty;
                        string stemp = sStr;
                        for(int i=sStr.Length-1; i >= 0; i--)
                        {
                            sreverse= sreverse + sStr[i];   
                        }
                        if(sreverse == stemp)
                        {
                            Console.WriteLine($"The given string {stemp} is Palindrome");
                        }
                        else
                        {
                            Console.WriteLine($"The given string {stemp} is not palindrom");
                        }
                        

                        break;

                     case 2:
                        Console.WriteLine("Enter any number ");
                        int input = Convert.ToInt32(Console.ReadLine());

                        int temp = input, rem, rev = 0;


                        while (input > 0)
                        {
                            rem = input % 10;
                            rev = rev * 10 + rem;
                            input /= 10;
                        }
                        if (rev == temp)
                        {
                            Console.WriteLine("The number is palindrome");
                        }
                        else
                        {
                            Console.WriteLine("The number is not  palindrome");
                        }
                        break;
                        case 3:
                       goto case (int)ModuleEnum.AssName.Assignment1;
                  

                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
                Console.WriteLine("Do u want continue ?");
                ch=Convert.ToChar(Console.ReadLine());

            } while (ch == 'y');
           


        }

        //2.N th prime number

        public void FindprimeNumber(int num)
        {


            int n = 1, count = 0, i;
            while (count < num)
            {
                n = n + 1;
                for (i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        break;
                    }

                }
                if (i == n)
                {
                    count = count + 1;
                }


            }

            Console.WriteLine($"the {num} th  prime number is  : {n}");

        }
        public int fibonaci(int fnum)
        {

            if (fnum <= 1)
            {
                return fnum;

            }
            else
            {
                return fibonaci(fnum - 1) + fibonaci(fnum - 2);
            }

        }
        public int factorial(int num)
        {
            if (num == 0)
            {
                return 1;

            }
            return num * factorial(num - 1);
        }


        //3.3. Write a complete program that inputs a positive integer n and then prints a
        //triangle of digits n lines high and 2n-1 columns wide

        public void Pattern()
        {
            int k;
            Console.WriteLine("Enter the nth number ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                k = i;
                for (int j = 1; j <= 2 * n - 1; j++)
                {
                    if (j >= (n+1) - i && j <= (n-1) + i)
                    {
                        Console.Write(k);
                        if (j >= n)
                        {
                            k--;

                        }
                        else
                        {
                            k++;
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }

    }
}
