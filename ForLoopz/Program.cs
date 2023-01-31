namespace ForLoopz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //while (x < 5)
            //{
            //    Console.WriteLine("Hello");
            //    x++;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Hello!");
            //}

            Console.WriteLine("Enter amount to say hello!");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}