namespace ProgrammingPractice.Ex02
{
    public class StairCase
    {
        public void stairCase(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string hashes = new string('#', i);
                Console.WriteLine(spaces + hashes);
            }
        }

        public void execute()
        {
            string input = Console.ReadLine();
            if (input == null)
            {
                throw new ArgumentNullException("Input cannot be null");
            }
            int n = Convert.ToInt32(input.Trim());
            stairCase(n);
        }
    }

}