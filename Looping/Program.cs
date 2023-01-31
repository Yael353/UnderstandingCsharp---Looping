namespace Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //while (x < 5) // 0 1 2 3 4 
            //{
            //    Console.WriteLine("Hello!");
            //    x++;
            //}

            int runningTotal = 0;
            Console.WriteLine("Enter a number, or -1 to quit");
            int number = int.Parse(Console.ReadLine());

            while (number != -1)
            {
                runningTotal += number;
                Console.WriteLine("Enter a number, or -1 to quit");
                number = int.Parse(Console.ReadLine());
            }
            // break point is here
            Console.WriteLine($"the total is {runningTotal}");
        }
    }
}