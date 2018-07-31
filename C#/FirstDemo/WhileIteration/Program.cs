using System;

namespace WhileIteration
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool displayMenu = true;
            while(displayMenu){
                displayMenu = MainMenu();
            }
        }


        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while(counter < result + 1){
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame(){
            Console.Clear();
            Console.WriteLine("Guessing game!");

           
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                int guess = int.Parse(Console.ReadLine());
                guesses++;

                if(guess == randomNumber){
                    incorrect = false;
                } else{
                    Console.WriteLine("Sorry, wrong answer. Please try again.");
                }

            } while (incorrect);
            Console.WriteLine("You did it correct.It took you {0} times.", guesses);

            Console.WriteLine();
        }
    }
}
