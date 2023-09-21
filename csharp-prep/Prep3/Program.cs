using System;

class Program
{
    static void Main(string[] args)
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            Random randomGenerator = new Random();
            int randomNum = randomGenerator.Next(1,100);
            int guess = 0;
            int guesses = 0;

            do
            {
                Console.Write("Guess: ");
                guess = int.Parse(Console.ReadLine());

                if (guess == randomNum)
                {
                    break;
                }
                else if (guess > randomNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Higher");
                }

                guesses ++;
            } while (guess != randomNum);

            Console.WriteLine($"Hurray! You guessed the correct number, {randomNum}");
            Console.WriteLine($"It took you {guesses} guesses");


            Console.WriteLine("Play again? (y/n)");
            string response = Console.ReadLine();

            if (response == "n")
            {
                isPlaying = false;
            }
        }
        
    }
}