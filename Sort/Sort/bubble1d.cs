using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class bubble1d
    {
        public static void Bubble1d()
        {
            int n, t;          //declaring variables

            Console.Write("enter size of array=");     //taking size of array through user
            n = Convert.ToInt32(Console.ReadLine());    //assigning size of array to variable n
            int[] a = new int[n];                   //initializing array with the user defined size 
            Console.WriteLine("enter elements in array :");

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                a[i] = Convert.ToInt32(Console.ReadLine());  //taking elements from user & storing in array   

            }


            Console.WriteLine("\n array is=");
            for (int i = 0; i < a.Length; i++)      //loop to display unsorted array elements on screen
            {
                Console.Write(a[i] + " ");
            }
            int N = 0;
            Stopwatch t1 = new Stopwatch();
            t1.Start();


            for (int i = 0; i < a.Length - 1; i++)      //loop to swap elements if they are in wrong order
            {
                Console.WriteLine("\n\nloop " + (i + 1) + ":");
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])        //checking condition for swapping, if true then swap
                    {

                        t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                        Console.WriteLine("  On pass " + (j + 1) + " no. " + a[j] + " & " + a[j + 1] + " swapped");
                        // printing each pass of each loop
                        N = N + 1;
                    }

                    else
                    {
                        Console.WriteLine("  On pass " + (j + 1) + " nos. are in order no swapping required");

                    }

                }

                Console.Write("elements after " + (i + 1) + " loop : ");
                for (int k = 0; k < a.Length; k++)
                {
                    Console.Write(a[k] + " ");
                }

            }

            Console.WriteLine("\n\nthe sorted array is=");

            for (int i = 0; i < a.Length; i++)      //loop to print sorted array
            {
                Console.Write(a[i] + " ");
            }

            t1.Stop();
            Console.WriteLine("\n\ntime complexity :"+N);
                Console.WriteLine("Best case Ω(n) = n");
                Console.WriteLine("Average case O(n2) =n2 ");
                Console.WriteLine("worst case O(n2) = n2");


            string ExecutionTimeTaken = string.Format("\nMinutes :{0}\nSeconds :{1}\nMili seconds :{2}", t1.Elapsed.Minutes, t1.Elapsed.Seconds, t1.Elapsed.TotalMilliseconds);
            Console.WriteLine("\nexecution time :" + ExecutionTimeTaken);


            Console.WriteLine("\n\n press enter key to exit :");
            
        }
    }
}
