using System;
using System.Runtime.CompilerServices;

namespace ProgrammingPractice.Ex02{
    public class SimpleArraySum
    {
        public int simpleArraySum(List<int> ar)
        {
           int sum = 0;
           foreach(int item in ar){
                sum += item;
           }
           return sum;
        }

        public void execute()
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int arCount = Convert.ToInt32(Console.ReadLine());
            List<int> ar = new List<int>();
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < arCount; i++)
            {
                int arItem = Convert.ToInt32(Console.ReadLine());
                ar.Add(arItem);
            }
            int result = simpleArraySum(ar);
            Console.WriteLine("The sum of the elements in the array is: " + result);
        }
    }
}

