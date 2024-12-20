namespace ProgrammingPractice.Ex02
{
    public class MinMaxSum
    {
        public void minMaxSum(List<int> array)
        {
            array.Sort();
            long minSum = 0;
            long maxSum = 0;

            for(int i = 0; i < 4; i++)
            {
                minSum += array[i];
                maxSum += array[array.Count -1 - i];
            }

            Console.WriteLine($"{minSum} {maxSum}");
        }

        public void execute()
        {
            string input = Console.ReadLine();
            if (input == null)
            {
                throw new ArgumentNullException("Input cannot be null");
            }
            List<int> array = input.Trim().Split(' ').Select(x => Convert.ToInt32(x)).ToList();
            minMaxSum(array);
        }
    }
}