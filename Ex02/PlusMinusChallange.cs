namespace ProgrammingPractice.Ex02
{
    public class PlusMinusChallange
    {
        public void plusMinus(List<int> arr)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            int totalCount = arr.Count;

            foreach(int num in arr)
            {
                if(num > 0)
                {
                    positiveCount++;
                }
                else if(num < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            double positiveRatio = (double)positiveCount / totalCount;
            double negativeRatio = (double)negativeCount / totalCount;
            double zeroRatio = (double)zeroCount / totalCount;

            Console.WriteLine(positiveRatio.ToString("F6"));
            Console.WriteLine(negativeRatio.ToString("F6"));
            Console.WriteLine(zeroRatio.ToString("F6"));
        }

        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);
        }

    }

}