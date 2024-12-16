using System;

namespace ProgrammingPractice.Ex02
{
    public class AVeryBigSum
    {
        public long averyBigSum(List<long> ar)
        {
            long sum = 0;
            foreach(long item in ar)
            {
                sum += item;
            }
            return sum;
        }

        public void execute()
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int arCount = Convert.ToInt32(Console.ReadLine());
            List<long> ar = new List<long>();
            Console.WriteLine("Enter the elements of the array:");
            for(int i = 0; i <arCount; i++)
            {
                long arItem = Convert.ToInt64(Console.ReadLine());
                ar.Add(arItem);
            }
            long result = averyBigSum(ar);
            Console.WriteLine("The sum of the elements in the array is: " + result);
        }
    }
}

