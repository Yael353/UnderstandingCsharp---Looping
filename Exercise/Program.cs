namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exersice1
            //while user enters values less than 2.65 
            //or greater than 49.99 continue to promt the user.
            // before the program ends, display valid pay rate.

            Console.WriteLine("Please enter a valid pay rate");
            double value = double.Parse(Console.ReadLine());

            while (value < 5.65 || value > 49.99)
            {
                Console.WriteLine("Please enter a valid pay rate");
                value = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Valid pay rate is between 5.65 and 49.99");
            
            
            Console.WriteLine("---------------------------------------------");

            double value2;
            do
            {
                Console.WriteLine("Please enter a valid pay rate");
                value2 = double.Parse(Console.ReadLine());

            } while (value2 < 5.65 || value2 > 49.99);
            Console.WriteLine($"The valid pay rate you entered is {value2}");

            // Exersice2 

            //Write a console-based application that sums the integers from 1 to 50.

            int totSum = 0;
            for (int i = 1; i <= 50; i++)
            {
                totSum += i;
            }
            Console.WriteLine($"The sum is {totSum}");


            //Exersice3

            // Write a program that generates a random number between 1 and 10.
            //ask user to guess the random number, then display the random number and a message
            //write a too high too low message or correct.

            //You can create a random number that is at least min but less than max using the following statements
            // Random randomGenerator = new Random();
            // int randomNumber = randomGenerator.Next(1,11); 



            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            int input;
            int amountOfGuesses = 0;
            do
            {
                Console.WriteLine("Enter a number between 1-10");
                input = int.Parse(Console.ReadLine());

                if (input < randomNumber)
                {
                    Console.WriteLine($"Your guess was too low.");
                }
                else if (input > randomNumber)
                {
                    Console.WriteLine("Your guess was to high.");
                }
                else
                    Console.WriteLine("Correct!");
                amountOfGuesses++;
            } while (input != randomNumber);
            Console.WriteLine($"You guessed {amountOfGuesses} times.");
        }
    }
}