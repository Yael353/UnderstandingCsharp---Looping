using System.Security.AccessControl;

namespace DoWhile
{
    internal class Program
    {

        // do while garuntees atleast one execution. condition comes at the end  of the actual loop.
        static void Main(string[] args)
        {
            //int x = 5;
            //do
            //{
            //    Console.WriteLine("Hello!");
            //    x++;

            //} while (x > 6);

            //Console.WriteLine("Hello");
            //string response = Console.ReadLine();

            //while (response == "again")
            //{
            //    Console.WriteLine("Hello");
            //    response = Console.ReadLine();
            //}

            string response;
            do
            {
                Console.WriteLine("hello");
                response = Console.ReadLine();
            } while (response == "again");


        }
    }
}