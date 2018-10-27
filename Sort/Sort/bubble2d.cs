using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class bubble2d
    {
        public static void Bubble2d()
        {

            int r, c, t;    //declaring variables
            Console.Write("enter size of array, row & col :- "); //asking user to enter the values
            r = Convert.ToInt32(Console.ReadLine());    //taking size of row from user
            c = Convert.ToInt32(Console.ReadLine());    //taking size of collumn from user
            int[,] a = new int[r, c];       //initializing 2 dimensional array of user defined size
            Console.WriteLine("enter elements:-");
            for (int i = 0; i < r; i++)     //loop for taking input from user
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());  //storing elements in array 
                }
            }
            Console.WriteLine("\narray is:- ");
            for (int i = 0; i < r; i++)     //loop for displaying array elements on screen
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("\n");
            }
            int N = 0;
            Stopwatch t1 = new Stopwatch();
            t1.Start();

            for (int k = 0; k < r; k++)     //loop for swapping array elements within each row
            {

                for (int i = 0; i < c; i++)
                {

                    for (int j = i + 1; j < c; j++)
                    {
                        Console.WriteLine("\nloop " + (k + 1) + "(" + (i + 1) + ")");
                        if (a[k, i] > a[k, j])      //checking condition for swapping, if true then swap
                        {
                            t = a[k, i];
                            a[k, i] = a[k, j];
                            a[k, j] = t;
                            Console.WriteLine("   on pass " + j + " swapping of elements " + a[k, i] + " & " + a[k, j]);
                            N = N + 1;
                        }
                        else
                            Console.WriteLine("   on pass " + j + " nos. are in order no swapping required");
                    }
                }
                Console.WriteLine("elements after loop " + (k + 1) + " are ");
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }


            Console.WriteLine("\nthe sorted array is:-");

            for (int i = 0; i < r; i++)     //loop for displaying sorted 2 dimensional array on screen
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            t1.Stop();
            Console.WriteLine("\n\ntime complexity :" + N);
            Console.WriteLine("Best case Ω(n) = n");
            Console.WriteLine("Average case O(n2) =n2 ");
            Console.WriteLine("worst case O(n2) = n2");

            string ExecutionTimeTaken = string.Format("\nMinutes :{0}\nSeconds :{1}\nMili seconds :{2}", t1.Elapsed.Minutes, t1.Elapsed.Seconds, t1.Elapsed.TotalMilliseconds);
            Console.WriteLine("\nexecution time :" + ExecutionTimeTaken);


            Console.WriteLine("\npress enter key to exit :");
            
        }
    }
}
