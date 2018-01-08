using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string S = Console.ReadLine();
            int number;
            bool canParse = Int32.TryParse(S, out number);
            if (canParse)
            {
                int search = number;
                Boolean result = BinarySearch(arr, search, 0, arr.Length - 1);
                if (result == true)
                {
                    Console.WriteLine("Found");
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bad String");
                Console.Read();
            }
            
        }
        private static Boolean BinarySearch(int[] arr, int searchFor, int left, int right)
        {
            if (left > right)
            {
                return false;
            }
            int midPoint = left + ((right - left) / 2); // avoid overflow
            if (arr[midPoint] == searchFor)
            {
                return true;
            }
            else if (searchFor < arr[midPoint])
            {
                return BinarySearch(arr, searchFor, left, midPoint - 1);
            }
            else
            {
                return BinarySearch(arr, searchFor, midPoint + 1, right);
            }
        }       
    }
}
