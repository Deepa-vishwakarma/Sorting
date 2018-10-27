using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. for 1Dimentional bubble sort ");
            Console.WriteLine("2. for 2Dimentional sort ");
            Console.WriteLine("3. for quick sort ");
            Console.WriteLine("4. for selection sort ");
            Console.WriteLine("5. for insertion sort ");
            

            Console .WriteLine("\nenter your choice: ");
            int option =Convert .ToInt32 ( Console.ReadLine());
            Console.WriteLine("\n\nyour choice is "+option );
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nSorting through bubble sort ");
                    bubble1d.Bubble1d();
                    break;
                case 2:
                    Console.WriteLine("\nSorting through bubble sort ");
                    bubble2d.Bubble2d();
                    break;
                case 3:
                    Console.WriteLine("\nSorting through quick sort ");
                    quick.Quick();
                    break;
                case 4:
                    Console.WriteLine("\nSorting through selection sort ");
                    selection.Selection();
                    break;
                case 5:
                    Console.WriteLine("\nSorting through insertion sort ");
                    insertion.Insertion();
                    break;
               
                default :
                    Console.WriteLine("invalid choice");
                    Console.WriteLine("press enter key to exit...");

                    break;
            }

            Console.Read();
        }
    }
}
