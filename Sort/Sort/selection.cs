using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class selection
    {
        public static void Selection()
        {

            //sorting 1 dimensional array using bubble sort
            int n;          //declaring variables

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

            int t, min;
            for (int i = 0; i < a.Length - 1; i++)      //loop to swap elements if they are in wrong order
            {
                Console.WriteLine("\n\nloop " + i + ":");
                min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }

                }
                if (min != i)
                {
                    t = a[min];
                    a[min] = a[i];
                    a[i] = t;

                }
                Console.WriteLine("  On pass " + i + " no. " + a[i] + " & " + a[min] + " swapped");
                // printing each pass of each loop
                N = N + 1;





                Console.Write("elements after " + i + " loop : ");
                for (int k = 0; k < a.Length; k++)
                {
                    Console.Write(a[k] + " ");
                }


            }

            Console.WriteLine("\n\nthe sorted array is=");

            for (int k = 0; k < a.Length; k++)      //loop to print sorted array
            {
                Console.Write(a[k] + " ");
            }

            t1.Stop();
            Console.WriteLine("\n\ntime complexity :" + N);
           
            Console.WriteLine("Best case Ω(n) = n2");
            Console.WriteLine("Average case O(n2) =n2 ");
            Console.WriteLine("worst case O(n2) = n2");


            string ExecutionTimeTaken = string.Format("\nMinutes :{0}\nSeconds :{1}\nMili seconds :{2}", t1.Elapsed.Minutes, t1.Elapsed.Seconds, t1.Elapsed.TotalMilliseconds);
            Console.WriteLine("\nexecution time :" + ExecutionTimeTaken);


            Console.WriteLine("\n\n press enter key to exit :");
               
        }
    }
}
