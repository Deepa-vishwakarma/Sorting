using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class quick
    {
        public static void Quick()
        {
            
            Console.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine()); //initializing no. of element in variable max 

            int[] num = new int[max]; // creating an array of user defined size

            for (int i = 0; i < max; i++)  //storing elements in array
            {
                Console.Write("\nEnter [" + (i + 1) + "] element: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("array is  : ");
            Console.Write("\n");
            for (int k = 0; k < max; k++) //printing elements of array
            {
                Console.Write(num[k] + "  ");

            }

            Stopwatch t1 = new Stopwatch();
            t1.Start();

            Console.WriteLine("\n\nsorting started....");
            int l = 1;
            N = 0;
            SortQuick(num, 0, max - 1, l);  //calling SortQuick() method for sorting
            Console.WriteLine("\n\nsorted array :");
            for (int i = 0; i < max; i++)  //printing sorted array elements
                Console.Write(+num[i] + "  ");


            t1.Stop();
            Console.WriteLine("\n\ntime complexity :" + N);
            Console.WriteLine("Best case Ω(n) = n log n");
            Console.WriteLine("Average case O(n2) =n log n");
            Console.WriteLine("worst case O(n2) = n2");

            string ExecutionTimeTaken = string.Format("\nMinutes :{0}\nSeconds :{1}\nMili seconds :{2}", t1.Elapsed.Minutes, t1.Elapsed.Seconds, t1.Elapsed.TotalMilliseconds);
            Console.WriteLine("\nexecution time :" + ExecutionTimeTaken);

            Console.WriteLine("\npress enter key to exit...."); 
           
        }
        public static int N;
        static public int Partition(int[] num, int left, int right)     //it picks a pivot and partition the array into sub arrays
        {
            int j = 1;

            int pi = num[left];
            while (true)
            {
                while (num[left] < pi)
                    left++;

                while (num[right] > pi)
                    right--;

                if (left < right)    //swapping of elements
                {
                    int temp = num[right];
                    num[right] = num[left];
                    num[left] = temp;

                    Console.WriteLine("swapping of elements " + num[right] + " & " + num[left] + " on " + j + " pass");
                    j++;
                    N = N + 1;

                }
                else
                {
                    Console.WriteLine("no swapping required on " + j + " pass");
                    j++;
                    return right;
                }

            }


        }

        static public void SortQuick(int[] arr, int left, int right, int l)
        {
            // For Recursion  
            int k = l;

            Console.WriteLine("\nloop " + k + ":");
            k++;
            if (left < right)
            {

                int pi = Partition(arr, left, right);       //variable pi store the pivot value returned from the Partition() and used for partioning & comparing.

                if (pi > 1)  //if condition is true then call method
                {

                    SortQuick(arr, left, pi - 1, k);

                }

                if (pi + 1 < right)      //if condition is true then call method
                {

                    SortQuick(arr, pi + 1, right, k);

                }

            }
        }

         
        }
    }

