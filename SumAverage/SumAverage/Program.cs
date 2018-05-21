using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAverage
{
    class Program
    {
        public void sumAverage(int[] arr, int size)
        {
            int sum = 0;
            int average = 0;
            for(int i=0; i<size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            Console.WriteLine("Sum of Array is: " + sum);
            Console.WriteLine("Average of Array is : "+ average);
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size: : ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the elements of the Array : ");
            for(int i = 0; i< size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int len = a.Length;
            Program pg = new Program();
            pg.sumAverage(a, len);
        }
    }
}
