namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write("{0, -2}","*");
                }
                Console.WriteLine();
            }
        }
    }
}